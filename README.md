# MaternityCare

## Overview
MaternityCare is a comprehensive platform designed to help expectant parents monitor and track fetal development, stay informed about important milestones, and engage with a supportive community. The system offers different membership packages, insightful blogs, and useful reminders, making pregnancy management easier and more informed.

## Primary Actors

### 1. **Guest Member**
- Can view general information about the system.
- Can browse blog posts and FAQs.
- Cannot access member-only features without registration.

### 2. **Registered Member**
- Register an account and choose a membership package.
- Update important fetal growth indicators (weight, length) over time.
- View fetal growth charts categorized by week.
- Receive alerts if fetal growth deviates from standard development indicators.
- Get reminders for important pregnancy milestones such as check-ups, tests, and vaccinations.
- Create appointment reminders with doctors.
- Share growth charts and pregnancy experiences with other members.

### 3. **Admin**
- Manage membership fee packages.
- Manage member profiles.
- View and generate reports via a dashboard.
- Oversee community discussions and shared content.

## Functional Requirements

1. **System Information Page**
   - Display an introduction to the system.
   - Provide details about membership packages.
   - Feature a blog section for sharing pregnancy-related experiences.
   - Include a Frequently Asked Questions (FAQ) section.

2. **Membership Management**
   - Allow users to register as members.
   - Enable members to choose a subscription package and make payments.

3. **Fetal Growth Tracking**
   - Members can update fetal growth indicators (weight, length) over time.
   - Display weekly fetal growth charts based on the recorded data.
   - Alert members if growth measurements do not meet weekly standards.

4. **Reminder System**
   - Notify members of upcoming pregnancy check-ups, tests, and vaccination schedules.

5. **Appointment Booking**
   - Allow members to create appointment reminders with doctors.

6. **Community Features**
   - Enable members to share growth charts and pregnancy experiences.
   - Provide an interactive forum where members can seek advice from others.

7. **Admin Features**
   - Manage membership packages and pricing.
   - Manage registered members and their profiles.
   - View and generate reports through a dashboard.
   
## Deployment
This project is hosted on GitHub. To run it locally, follow these steps:

```bash
# Clone the repository
git clone https://github.com/your-repo-url.git

# Navigate to the project directory
cd maternitycare

# Install dependencies (if applicable)
npm install  # For React frontend
dotnet restore  # For .NET backend

# Run the application
npm start  # React frontend
dotnet run  # .NET backend
```

## Technologies Used
- **Frontend**: React, CSS
- **Backend**: .NET 8.0 API
- **Database**: SQL Server
- **Authentication**: JWT-based authentication

## Future Enhancements
- AI-powered insights for personalized pregnancy tracking.
- Integration with wearable devices for real-time tracking.
- Mobile app version for easier access.

## License
This project is licensed under the MIT License. See `LICENSE` for details.

---
**Author:** MaternityCareTeam  
**GitHub Repository:** [Project Link](https://github.com/muckho2728/MaternityCare_SWP391)


