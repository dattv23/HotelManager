import mongoose from 'mongoose';
const Schema = mongoose.Schema;

const UserSchema = new Schema({
      name: String,
      phone: String,
      email: String,
      address: String,
      accountType: Number, // 0: Client, 1: Member, 2: Mananger
      account: {
            username: String,
            password: String,
            status: Number // 0: NotActive, 1: Active
      }
});

export const User = mongoose.model('User', UserSchema);