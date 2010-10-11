namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccountAuthenticatorResponse : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccountAuthenticatorResponse()
		{
			InitJNI();
		}
		protected AccountAuthenticatorResponse(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel67;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorResponse._writeToParcel67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorResponse.staticClass, global::android.accounts.AccountAuthenticatorResponse._writeToParcel67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents68;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorResponse._describeContents68);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorResponse.staticClass, global::android.accounts.AccountAuthenticatorResponse._describeContents68);
		}
		internal static global::MonoJavaBridge.MethodId _onResult69;
		public virtual void onResult(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorResponse._onResult69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorResponse.staticClass, global::android.accounts.AccountAuthenticatorResponse._onResult69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRequestContinued70;
		public virtual void onRequestContinued() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorResponse._onRequestContinued70);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorResponse.staticClass, global::android.accounts.AccountAuthenticatorResponse._onRequestContinued70);
		}
		internal static global::MonoJavaBridge.MethodId _onError71;
		public virtual void onError(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorResponse._onError71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorResponse.staticClass, global::android.accounts.AccountAuthenticatorResponse._onError71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AccountAuthenticatorResponse72;
		public AccountAuthenticatorResponse(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountAuthenticatorResponse.staticClass, global::android.accounts.AccountAuthenticatorResponse._AccountAuthenticatorResponse72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR73;
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
			global::android.accounts.AccountAuthenticatorResponse.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountAuthenticatorResponse"));
			global::android.accounts.AccountAuthenticatorResponse._writeToParcel67 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorResponse.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.accounts.AccountAuthenticatorResponse._describeContents68 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorResponse.staticClass, "describeContents", "()I");
			global::android.accounts.AccountAuthenticatorResponse._onResult69 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorResponse.staticClass, "onResult", "(Landroid/os/Bundle;)V");
			global::android.accounts.AccountAuthenticatorResponse._onRequestContinued70 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorResponse.staticClass, "onRequestContinued", "()V");
			global::android.accounts.AccountAuthenticatorResponse._onError71 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorResponse.staticClass, "onError", "(ILjava/lang/String;)V");
			global::android.accounts.AccountAuthenticatorResponse._AccountAuthenticatorResponse72 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorResponse.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
