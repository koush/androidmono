namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PeriodicSync : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PeriodicSync(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals3490;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.PeriodicSync._equals3490.native == global::System.IntPtr.Zero)
				global::android.content.PeriodicSync._equals3490 = @__env.GetMethodIDNoThrow(global::android.content.PeriodicSync.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._equals3490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3491;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.PeriodicSync._writeToParcel3491.native == global::System.IntPtr.Zero)
				global::android.content.PeriodicSync._writeToParcel3491 = @__env.GetMethodIDNoThrow(global::android.content.PeriodicSync.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._writeToParcel3491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3492;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.PeriodicSync._describeContents3492.native == global::System.IntPtr.Zero)
				global::android.content.PeriodicSync._describeContents3492 = @__env.GetMethodIDNoThrow(global::android.content.PeriodicSync.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._describeContents3492);
		}
		internal static global::MonoJavaBridge.MethodId _PeriodicSync3493;
		public PeriodicSync(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, long arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.PeriodicSync._PeriodicSync3493.native == global::System.IntPtr.Zero)
				global::android.content.PeriodicSync._PeriodicSync3493 = @__env.GetMethodIDNoThrow(global::android.content.PeriodicSync.staticClass, "<init>", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._PeriodicSync3493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _account3494;
		public global::android.accounts.Account account
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _account3494)) as android.accounts.Account;
			}
		}
		internal static global::MonoJavaBridge.FieldId _authority3495;
		public global::java.lang.String authority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _authority3495)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _extras3496;
		public global::android.os.Bundle extras
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.GetObjectField(this.JvmHandle, _extras3496)) as android.os.Bundle;
			}
		}
		internal static global::MonoJavaBridge.FieldId _period3497;
		public long period
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _period3497);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3498;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.PeriodicSync.staticClass, _CREATOR3498)) as android.os.Parcelable_Creator;
			}
		}
		static PeriodicSync()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.PeriodicSync.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/PeriodicSync"));
			global::android.content.PeriodicSync._account3494 = @__env.GetFieldIDNoThrow(global::android.content.PeriodicSync.staticClass, "account", "Landroid/accounts/Account;");
			global::android.content.PeriodicSync._authority3495 = @__env.GetFieldIDNoThrow(global::android.content.PeriodicSync.staticClass, "authority", "Ljava/lang/String;");
			global::android.content.PeriodicSync._extras3496 = @__env.GetFieldIDNoThrow(global::android.content.PeriodicSync.staticClass, "extras", "Landroid/os/Bundle;");
			global::android.content.PeriodicSync._period3497 = @__env.GetFieldIDNoThrow(global::android.content.PeriodicSync.staticClass, "period", "J");
			global::android.content.PeriodicSync._CREATOR3498 = @__env.GetStaticFieldIDNoThrow(global::android.content.PeriodicSync.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
