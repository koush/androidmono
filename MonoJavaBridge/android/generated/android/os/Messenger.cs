namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Messenger : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Messenger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Messenger.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.os.Messenger._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Messenger.staticClass, "hashCode", "()I", ref global::android.os.Messenger._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void send(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Messenger.staticClass, "send", "(Landroid/os/Message;)V", ref global::android.os.Messenger._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Messenger.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.os.Messenger._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Messenger.staticClass, "describeContents", "()I", ref global::android.os.Messenger._m4);
		}
		public new global::android.os.IBinder Binder
		{
			get
			{
				return getBinder();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::android.os.IBinder getBinder()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.os.Messenger.staticClass, "getBinder", "()Landroid/os/IBinder;", ref global::android.os.Messenger._m5) as android.os.IBinder;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void writeMessengerOrNullToParcel(android.os.Messenger arg0, android.os.Parcel arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Messenger._m6.native == global::System.IntPtr.Zero)
				global::android.os.Messenger._m6 = @__env.GetStaticMethodIDNoThrow(global::android.os.Messenger.staticClass, "writeMessengerOrNullToParcel", "(Landroid/os/Messenger;Landroid/os/Parcel;)V");
			@__env.CallStaticVoidMethod(android.os.Messenger.staticClass, global::android.os.Messenger._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::android.os.Messenger readMessengerOrNullFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Messenger._m7.native == global::System.IntPtr.Zero)
				global::android.os.Messenger._m7 = @__env.GetStaticMethodIDNoThrow(global::android.os.Messenger.staticClass, "readMessengerOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/os/Messenger;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Messenger>(@__env.CallStaticObjectMethod(android.os.Messenger.staticClass, global::android.os.Messenger._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Messenger;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public Messenger(android.os.Handler arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Messenger._m8.native == global::System.IntPtr.Zero)
				global::android.os.Messenger._m8 = @__env.GetMethodIDNoThrow(global::android.os.Messenger.staticClass, "<init>", "(Landroid/os/Handler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Messenger.staticClass, global::android.os.Messenger._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public Messenger(android.os.IBinder arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Messenger._m9.native == global::System.IntPtr.Zero)
				global::android.os.Messenger._m9 = @__env.GetMethodIDNoThrow(global::android.os.Messenger.staticClass, "<init>", "(Landroid/os/IBinder;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Messenger.staticClass, global::android.os.Messenger._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4009;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.Messenger.staticClass, _CREATOR4009)) as android.os.Parcelable_Creator;
			}
		}
		static Messenger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Messenger.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Messenger"));
			global::android.os.Messenger._CREATOR4009 = @__env.GetStaticFieldIDNoThrow(global::android.os.Messenger.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
