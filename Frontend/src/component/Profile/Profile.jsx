import  { useEffect, useState } from 'react';
import { useSelector, useDispatch } from 'react-redux';
import { Layout, Input, Button, Form, Typography, Card, Row, Col,  Space, message, Upload } from 'antd';
import { updateUserByIdAction } from '../../store/redux/action/userAction';
import {changePassworbyUserIdAction} from '../../store/redux/action/userAction';
import { fetchUserByIdAction } from '../../store/redux/action/userAction';

const { Content } = Layout;
const { Title } = Typography;

const Profile = () => {
  const userId='3e852369-e934-4184-97db-08dd4921d556';
  const dispatch = useDispatch();
  const [profileForm] = Form.useForm();
  const [passwordForm] = Form.useForm();
  const userLogin = useSelector((state) => state.userReducer.currentUser);
  const userDetailData = useSelector(state => state.userReducer.user);
  const [previewAvatar, setPreviewAvatar] = useState(null);

  useEffect(() => {
    if(userLogin) {
      dispatch(fetchUserByIdAction(userId));
    }
  }, [dispatch, userLogin]);


  useEffect(() => {
    if (userDetailData) {
      profileForm.setFieldsValue({
        roleId: userDetailData.role?.name || '',
        username: userDetailData?.username,
        password: userDetailData?.password,
        email: userDetailData?.email,
        fullName: userDetailData?.fullName,
        cccd: userDetailData?.cccd,
        dateOfBirth: userDetailData?.dateOfBirth,
        avatar: userDetailData?.avatar,
        experience: userDetailData?.experience,
        status: userDetailData?.status,
      });
    }
  }, [userDetailData, profileForm]);

  const handleSubmit = async(values) => {
    const formData = new FormData();
    formData.append('fullName', values.fullName);
    formData.append('dateOfBirth', values.dateOfBirth);

    if (previewAvatar) {
      const response = await fetch(previewAvatar);
      const blob = await response.blob();
      
      // Lấy tên gốc từ URL nếu có
      const fileName = previewAvatar.split('/').pop() || 'avatar.png';
      
      formData.append('avatar', blob, fileName);
    }

    dispatch(updateUserByIdAction(userDetailData.id, formData))
      .then(() => {
        message.success('Cập nhật thông tin thành công!');

        dispatch(fetchUserByIdAction(userDetailData.id));
      })
      .catch((error) => {
        message.error('Cập nhật thông tin thất bại: ' + (error.message || 'Lỗi không xác định'));
      });
  };

  const handleSubmitPassword = (values) => {
    const { currentPassword, newPassword, confirmPassword } = values;
    if (newPassword !== confirmPassword) {
      message.error('Mật khẩu mới không khớp!');
      return;
    }

    const userDetails = {
      currentPassword: currentPassword,
      newPassword: newPassword,
      confirmPassword: confirmPassword,

    };

    dispatch(changePassworbyUserIdAction(userDetailData.id, userDetails))
      .then(() => {
        message.success('Đổi mật khẩu thành công!');
        dispatch(fetchUserByIdAction(userDetailData.id));
      })
      .catch((error) => {
        message.error('Đổi mật khẩu thất bại: ' + (error.message || 'Lỗi không xác định'));
      });
  }

  // if (!userLogin) {
  //   return null; 
  // }

  return (
    <Layout style={{ minHeight: '100vh', width: '100vw' }}>
      <Content style={{ padding: '80px 24px', marginTop: '64px' }}>
        <Card style={{ maxWidth: 1200, margin: '0 auto', padding: 24, borderRadius: '10px', boxShadow: '0 2px 10px rgba(0,0,0,0.1)' }}>
          <Row gutter={24}>
            <Col span={8} style={{ textAlign: 'center' }}>
              <Title level={3}>Ảnh đại diện</Title>
                <Upload
                  name="avatar"
                  listType="picture-card"
                  showUploadList={false}
                  beforeUpload={(file) => {
                    // Hiển thị ảnh mới ngay lập tức
                    const reader = new FileReader();
                    reader.onload = (e) => setPreviewAvatar(e.target.result);
                    reader.readAsDataURL(file);

                    // Cập nhật giá trị trong form để khi nhấn "Save", ảnh mới được gửi
                    profileForm.setFieldsValue({ avatar: [file] });

                    return false; // Ngăn chặn upload tự động
                  }}
                >
                  <img 
                    src={previewAvatar || userDetailData.avatar} 
                    alt="avatar" 
                    style={{ width: '100%' }} 
                  />
                </Upload>
              <Title level={4}>{userLogin?.fullName}</Title>
              <p>{userLogin?.email}</p>
              <p>{userLogin?.phone}</p>
              <p>{userLogin?.address}</p>
            </Col>
            <Col span={16}>
              <Title level={3}>Thông tin cá nhân</Title>
              <Form
                form={profileForm}
                onFinish={handleSubmit}
                layout="vertical"
                style={{ backgroundColor: '#f9f9f9', padding: '20px', borderRadius: '8px' }}
              >
                <Row gutter={16}>
                  <Col span={12}>
                    <Form.Item label="Họ và Tên" name="fullName">
                      <Input />
                    </Form.Item>
                  </Col>
                  <Col span={12}>
                    <Form.Item label="Email" name="email">
                      <Input disabled />
                    </Form.Item>
                  </Col>
                  <Col span={12}>
                    <Form.Item label="Tên đăng nhập" name="username">
                      <Input disabled />
                    </Form.Item>
                  </Col>
                  
                  <Col span={12}>
                    <Form.Item label="Căn cước công dân" name="cccd">
                      <Input disabled />
                    </Form.Item>
                  </Col>
                  <Col span={12}>
                    <Form.Item label="Ngày Sinh" name="dateOfBirth">
                      <Input type="date" />
                    </Form.Item>
                  </Col>
                  <Col span={12}>
                    <Form.Item label="Kinh Nghiệm" name="experience">
                      <Input type="number" disabled/>
                    </Form.Item>
                  </Col>
                  <Col span={12}>
                    <Form.Item label="Vai Trò" name="roleId">
                      <Input disabled />
                    </Form.Item>
                  </Col>
                  <Col span={12}>
                    <Form.Item label="Trạng Thái" name="status">
                      <Input disabled  />
                    </Form.Item>
                  </Col>
                </Row>
                <Form.Item>
                  <Space style={{ display: 'flex', justifyContent: 'center' }}>
                    <Button type="primary" htmlType="submit" style={{ width: '100%' }}>
                      Lưu
                    </Button>
                  </Space>
                </Form.Item>
              </Form>
              <Title level={3}>Đổi mật khẩu</Title>
              <Form
                form={passwordForm}
                onFinish={handleSubmitPassword}
                layout="vertical"
                style={{ backgroundColor: '#f9f9f9', padding: '20px', borderRadius: '8px' }}
              >
                <Row gutter={16}>
                  <Col span={12}>
                    <Form.Item label="Mật Khẩu Cũ" name="currentPassword">
                      <Input.Password />
                    </Form.Item>
                  </Col>
                  <Col span={12}>
                    <Form.Item label="Mật Khẩu Mới" name="newPassword">
                      <Input.Password />
                    </Form.Item>
                  </Col>
                  <Col span={12}>
                    <Form.Item label="Nhập Lại Mật Khẩu" name="confirmPassword">
                      <Input.Password />
                    </Form.Item>
                  </Col>
                </Row>
                <Form.Item>
                  <Space style={{ display: 'flex', justifyContent: 'center' }}>
                    <Button type="primary" htmlType="submit" style={{ width: '100%' }}>
                      Lưu
                    </Button>
                  </Space>
                </Form.Item>

              </Form>
            </Col>
          </Row>
        </Card>
      </Content>
    </Layout>
  );
};

export default Profile;
