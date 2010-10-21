namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Messenger : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Messenger()
		{
			InitJNI();
		}
		internal Messenger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals9920;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Messenger._equals9920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Messenger.staticClass, global::android.os.Messenger._equals9920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode9921;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Messenger._hashCode9921);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Messenger.staticClass, global::android.os.Messenger._hashCode9921);
		}
		internal static global::MonoJavaBridge.MethodId _send9922;
		public void send(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Messenger._send9922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Messenger.staticClass, global::android.os.Messenger._send9922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel9923;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Messenger._writeToParcel9923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Messenger.staticClass, global::android.os.Messenger._writeToParcel9923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents9924;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Messenger._describeContents9924);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Messenger.staticClass, global::android.os.Messenger._describeContents9924);
		}
		public new global::android.os.IBinder Binder
		{
			get
			{
				return getBinder();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinder9925;
		public global::android.os.IBinder getBinder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Messenger._getBinder9925)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Messenger.staticClass, global::android.os.Messenger._getBinder9925)) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _writeMessengerOrNullToParcel9926;
		public static void writeMessengerOrNullToParcel(android.os.Messenger arg0, android.os.Parcel arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Messenger.staticClass, global::android.os.Messenger._writeMessengerOrNullToParcel9926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readMessengerOrNullFromParcel9927;
		public static global::android.os.Messenger readMessengerOrNullFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Messenger.staticClass, global::android.os.Messenger._readMessengerOrNullFromParcel9927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Messenger;
		}
		internal static global::MonoJavaBridge.MethodId _Messenger9928;
		public Messenger(android.os.Handler arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Messenger.staticClass, global::android.os.Messenger._Messenger9928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Messenger9929;
		public Messenger(android.os.IBinder arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Messenger.staticClass, global::android.os.Messenger._Messenger9929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR9930;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.Messenger.staticClass, _CREATOR9930)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Messenger.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Messenger"));
			global::android.os.Messenger._equals9920 = @__env.GetMethodIDNoThrow(global::android.os.Messenger.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.os.Messenger._hashCode9921 = @__env.GetMethodIDNoThrow(global::android.os.Messenger.staticClass, "hashCode", "()I");
			global::android.os.Messenger._send9922 = @__env.GetMethodIDNoThrow(global::android.os.Messenger.staticClass, "send", "(Landroid/os/Message;)V");
			global::android.os.Messenger._writeToParcel9923 = @__env.GetMethodIDNoThrow(global::android.os.Messenger.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.Messenger._describeContents9924 = @__env.GetMethodIDNoThrow(global::android.os.Messenger.staticClass, "describeContents", "()I");
			global::android.os.Messenger._getBinder9925 = @__env.GetMethodIDNoThrow(global::android.os.Messenger.staticClass, "getBinder", "()Landroid/os/IBinder;");
			global::android.os.Messenger._writeMessengerOrNullToParcel9926 = @__env.GetStaticMethodIDNoThrow(global::android.os.Messenger.staticClass, "writeMessengerOrNullToParcel", "(Landroid/os/Messenger;Landroid/os/Parcel;)V");
			global::android.os.Messenger._readMessengerOrNullFromParcel9927 = @__env.GetStaticMethodIDNoThrow(global::android.os.Messenger.staticClass, "readMessengerOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/os/Messenger;");
			global::android.os.Messenger._Messenger9928 = @__env.GetMethodIDNoThrow(global::android.os.Messenger.staticClass, "<init>", "(Landroid/os/Handler;)V");
			global::android.os.Messenger._Messenger9929 = @__env.GetMethodIDNoThrow(global::android.os.Messenger.staticClass, "<init>", "(Landroid/os/IBinder;)V");
			global::android.os.Messenger._CREATOR9930 = @__env.GetStaticFieldIDNoThrow(global::android.os.Messenger.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
