import mongoose from 'mongoose';

const NotificationSchema = new mongoose.Schema({
      notificationId: Number,
      createdOn: Date,
      content: String,
});

export const Notification = mongoose.model('Notification', NotificationSchema);

