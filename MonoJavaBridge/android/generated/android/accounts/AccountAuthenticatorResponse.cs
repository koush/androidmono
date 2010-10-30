namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccountAuthenticatorResponse : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AccountAuthenticatorResponse(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.accounts.AccountAuthenticatorResponse._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.accounts.AccountAuthenticatorResponse.staticClass, "describeContents", "()I", ref global::android.accounts.AccountAuthenticatorResponse._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void onResult(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse.staticClass, "onResult", "(Landroid/os/Bundle;)V", ref global::android.accounts.AccountAuthenticatorResponse._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void onRequestContinued()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse.staticClass, "onRequestContinued", "()V", ref global::android.accounts.AccountAuthenticatorResponse._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void onError(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse.staticClass, "onError", "(ILjava/lang/String;)V", ref global::android.accounts.AccountAuthenticatorResponse._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public AccountAuthenticatorResponse(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AccountAuthenticatorResponse._m5.native == global::System.IntPtr.Zero)
				global::android.accounts.AccountAuthenticatorResponse._m5 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorResponse.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountAuthenticatorResponse.staticClass, global::android.accounts.AccountAuthenticatorResponse._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1234;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.accounts.AccountAuthenticatorResponse.staticClass, _CREATOR1234)) as android.os.Parcelable_Creator;
			}
		}
		static AccountAuthenticatorResponse()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AccountAuthenticatorResponse.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountAuthenticatorResponse"));
			global::android.accounts.AccountAuthenticatorResponse._CREATOR1234 = @__env.GetStaticFieldIDNoThrow(global::android.accounts.AccountAuthenticatorResponse.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
