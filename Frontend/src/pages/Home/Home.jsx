import { Carousel } from "antd";
import React from "react";
import slide1 from "../../assets/Slide1.png";
import "./Home.css";

const Home = () => {
	return (
		<div className="home">
			<main className="main-content">
				<section className="introduction">
					<div className="carousel">
						<Carousel autoplay>
							<div>
								<img
									src={slide1}
									alt="Slide 1"
									style={{ width: "100%", height: "auto", maxHeight: "400px" }}
								/>
							</div>
							<div>
								<h3>Slide 2</h3>
							</div>
							<div>
								<h3>Slide 3</h3>
							</div>
							<div>
								<h3>Slide 4</h3>
							</div>
						</Carousel>
					</div>
					<div className="introduction-text">
						<h2>INTRODUCTION</h2>
						<p>
							Chào mừng bạn đến với Maternity Care, nơi đồng hành cùng mẹ bầu
							trong hành trình mang thai đầy kỳ diệu. Trang web của chúng tôi
							cung cấp thông tin chi tiết, khoa học và dễ hiểu về sự phát triển
							của thai nhi qua từng tuần, cùng với các lời khuyên chăm sóc sức
							khỏe cho mẹ bầu. Từ việc giải đáp những thắc mắc thường gặp, đến
							hướng dẫn dinh dưỡng, luyện tập, và chuẩn bị tâm lý, Maternity
							Care mong muốn trở thành người bạn đáng tin cậy giúp bạn và bé yêu
							có một thai kỳ khỏe mạnh và hạnh phúc. Hãy cùng khám phá hành
							trình phát triển kỳ diệu của bé ngay hôm nay!
						</p>
					</div>
				</section>
			</main>
		</div>
	);
};

export default Home;
