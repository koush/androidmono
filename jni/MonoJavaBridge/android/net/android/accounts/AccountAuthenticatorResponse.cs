namespace android.accounts 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AccountAuthenticatorResponse : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static AccountAuthenticatorResponse() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.accounts.AccountAuthenticatorResponse), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.accounts.AccountAuthenticatorResponse(@__env); 
			} 
		} 
		protected AccountAuthenticatorResponse(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel58; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.AccountAuthenticatorResponse)) 
				@__env.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse._writeToParcel58, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse.staticClass, global::android.accounts.AccountAuthenticatorResponse._writeToParcel58, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents59; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.AccountAuthenticatorResponse)) 
				return @__env.CallIntMethod(this, global::android.accounts.AccountAuthenticatorResponse._describeContents59); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.accounts.AccountAuthenticatorResponse.staticClass, global::android.accounts.AccountAuthenticatorResponse._describeContents59); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onResult60; 
		public virtual void onResult(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.AccountAuthenticatorResponse)) 
				@__env.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse._onResult60, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse.staticClass, global::android.accounts.AccountAuthenticatorResponse._onResult60, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRequestContinued61; 
		public virtual void onRequestContinued() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.AccountAuthenticatorResponse)) 
				@__env.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse._onRequestContinued61); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse.staticClass, global::android.accounts.AccountAuthenticatorResponse._onRequestContinued61); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onError62; 
		public virtual void onError(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.AccountAuthenticatorResponse)) 
				@__env.CallVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse._onError62, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.accounts.AccountAuthenticatorResponse.staticClass, global::android.accounts.AccountAuthenticatorResponse._onError62, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AccountAuthenticatorResponse63; 
		public AccountAuthenticatorResponse(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.AccountAuthenticatorResponse.staticClass, global::android.accounts.AccountAuthenticatorResponse._AccountAuthenticatorResponse63, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR64; 
		public static global::android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(global::android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.accounts.AccountAuthenticatorResponse.staticClass = @__class; 
			global::android.accounts.AccountAuthenticatorResponse._writeToParcel58 = @__env.GetMethodID(global::android.accounts.AccountAuthenticatorResponse.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.accounts.AccountAuthenticatorResponse._describeContents59 = @__env.GetMethodID(global::android.accounts.AccountAuthenticatorResponse.staticClass, "describeContents", "()I"); 
			global::android.accounts.AccountAuthenticatorResponse._onResult60 = @__env.GetMethodID(global::android.accounts.AccountAuthenticatorResponse.staticClass, "onResult", "(Landroid/os/Bundle;)V"); 
			global::android.accounts.AccountAuthenticatorResponse._onRequestContinued61 = @__env.GetMethodID(global::android.accounts.AccountAuthenticatorResponse.staticClass, "onRequestContinued", "()V"); 
			global::android.accounts.AccountAuthenticatorResponse._onError62 = @__env.GetMethodID(global::android.accounts.AccountAuthenticatorResponse.staticClass, "onError", "(ILjava/lang/String;)V"); 
			global::android.accounts.AccountAuthenticatorResponse._AccountAuthenticatorResponse63 = @__env.GetMethodID(global::android.accounts.AccountAuthenticatorResponse.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
