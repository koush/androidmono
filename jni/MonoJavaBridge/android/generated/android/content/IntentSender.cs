namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IntentSender : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IntentSender()
		{
			InitJNI();
		}
		protected IntentSender(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.IntentSender.OnFinished_))]
		public interface OnFinished  : global::MonoJavaBridge.IJavaObject 
		{
			void onSendFinished(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.IntentSender.OnFinished))]
		public sealed partial class OnFinished_ : java.lang.Object, OnFinished
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnFinished_()
			{
				InitJNI();
			}
			internal OnFinished_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onSendFinished1715;
			 void android.content.IntentSender.OnFinished.onSendFinished(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentSender.OnFinished_._onSendFinished1715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentSender.OnFinished_.staticClass, global::android.content.IntentSender.OnFinished_._onSendFinished1715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentSender.OnFinished_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentSender$OnFinished"));
				global::android.content.IntentSender.OnFinished_._onSendFinished1715 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.OnFinished_.staticClass, "onSendFinished", "(Landroid/content/IntentSender;Landroid/content/Intent;ILjava/lang/String;Landroid/os/Bundle;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SendIntentException : android.util.AndroidException
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SendIntentException()
			{
				InitJNI();
			}
			protected SendIntentException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _SendIntentException1716;
			public SendIntentException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentSender.SendIntentException.staticClass, global::android.content.IntentSender.SendIntentException._SendIntentException1716);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _SendIntentException1717;
			public SendIntentException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentSender.SendIntentException.staticClass, global::android.content.IntentSender.SendIntentException._SendIntentException1717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _SendIntentException1718;
			public SendIntentException(java.lang.Exception arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.IntentSender.SendIntentException.staticClass, global::android.content.IntentSender.SendIntentException._SendIntentException1718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.IntentSender.SendIntentException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentSender$SendIntentException"));
				global::android.content.IntentSender.SendIntentException._SendIntentException1716 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.SendIntentException.staticClass, "<init>", "()V");
				global::android.content.IntentSender.SendIntentException._SendIntentException1717 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.SendIntentException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::android.content.IntentSender.SendIntentException._SendIntentException1718 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.SendIntentException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals1719;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.IntentSender._equals1719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._equals1719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString1720;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.IntentSender._toString1720)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._toString1720)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode1721;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentSender._hashCode1721);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._hashCode1721);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1722;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentSender._writeToParcel1722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._writeToParcel1722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1723;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.IntentSender._describeContents1723);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._describeContents1723);
		}
		internal static global::MonoJavaBridge.MethodId _sendIntent1724;
		public virtual void sendIntent(android.content.Context arg0, int arg1, android.content.Intent arg2, android.content.IntentSender.OnFinished arg3, android.os.Handler arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.IntentSender._sendIntent1724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._sendIntent1724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _writeIntentSenderOrNullToParcel1725;
		public static void writeIntentSenderOrNullToParcel(android.content.IntentSender arg0, android.os.Parcel arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.IntentSender.staticClass, global::android.content.IntentSender._writeIntentSenderOrNullToParcel1725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readIntentSenderOrNullFromParcel1726;
		public static global::android.content.IntentSender readIntentSenderOrNullFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.IntentSender.staticClass, global::android.content.IntentSender._readIntentSenderOrNullFromParcel1726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.IntentSender;
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1727;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.IntentSender.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/IntentSender"));
			global::android.content.IntentSender._equals1719 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.IntentSender._toString1720 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.IntentSender._hashCode1721 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.staticClass, "hashCode", "()I");
			global::android.content.IntentSender._writeToParcel1722 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.IntentSender._describeContents1723 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.staticClass, "describeContents", "()I");
			global::android.content.IntentSender._sendIntent1724 = @__env.GetMethodIDNoThrow(global::android.content.IntentSender.staticClass, "sendIntent", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/content/IntentSender$OnFinished;Landroid/os/Handler;)V");
			global::android.content.IntentSender._writeIntentSenderOrNullToParcel1725 = @__env.GetStaticMethodIDNoThrow(global::android.content.IntentSender.staticClass, "writeIntentSenderOrNullToParcel", "(Landroid/content/IntentSender;Landroid/os/Parcel;)V");
			global::android.content.IntentSender._readIntentSenderOrNullFromParcel1726 = @__env.GetStaticMethodIDNoThrow(global::android.content.IntentSender.staticClass, "readIntentSenderOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/content/IntentSender;");
		}
	}
}
