namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PeriodicSync : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PeriodicSync(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.PeriodicSync.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.content.PeriodicSync._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.PeriodicSync.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.PeriodicSync._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.PeriodicSync.staticClass, "describeContents", "()I", ref global::android.content.PeriodicSync._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public PeriodicSync(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, long arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.PeriodicSync._m3.native == global::System.IntPtr.Zero)
				global::android.content.PeriodicSync._m3 = @__env.GetMethodIDNoThrow(global::android.content.PeriodicSync.staticClass, "<init>", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _account1871;
		public global::android.accounts.Account account
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _account1871)) as android.accounts.Account;
			}
		}
		internal static global::MonoJavaBridge.FieldId _authority1872;
		public global::java.lang.String authority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _authority1872)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _extras1873;
		public global::android.os.Bundle extras
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.GetObjectField(this.JvmHandle, _extras1873)) as android.os.Bundle;
			}
		}
		internal static global::MonoJavaBridge.FieldId _period1874;
		public long period
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _period1874);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1875;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.PeriodicSync.staticClass, _CREATOR1875)) as android.os.Parcelable_Creator;
			}
		}
		static PeriodicSync()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.PeriodicSync.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/PeriodicSync"));
			global::android.content.PeriodicSync._account1871 = @__env.GetFieldIDNoThrow(global::android.content.PeriodicSync.staticClass, "account", "Landroid/accounts/Account;");
			global::android.content.PeriodicSync._authority1872 = @__env.GetFieldIDNoThrow(global::android.content.PeriodicSync.staticClass, "authority", "Ljava/lang/String;");
			global::android.content.PeriodicSync._extras1873 = @__env.GetFieldIDNoThrow(global::android.content.PeriodicSync.staticClass, "extras", "Landroid/os/Bundle;");
			global::android.content.PeriodicSync._period1874 = @__env.GetFieldIDNoThrow(global::android.content.PeriodicSync.staticClass, "period", "J");
			global::android.content.PeriodicSync._CREATOR1875 = @__env.GetStaticFieldIDNoThrow(global::android.content.PeriodicSync.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
