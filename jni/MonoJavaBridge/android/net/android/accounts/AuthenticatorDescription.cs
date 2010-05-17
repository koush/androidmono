namespace android.accounts 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AuthenticatorDescription : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static AuthenticatorDescription() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.accounts.AuthenticatorDescription), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.accounts.AuthenticatorDescription(@__env); 
			} 
		} 
		protected AuthenticatorDescription(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode94; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.AuthenticatorDescription)) 
				return @__env.CallIntMethod(this, _hashCode94); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.accounts.AuthenticatorDescription.staticClass, _hashCode94); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals95; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.AuthenticatorDescription)) 
				return @__env.CallBooleanMethod(this, _equals95, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.accounts.AuthenticatorDescription.staticClass, _equals95, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString96; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.AuthenticatorDescription)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString96)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.accounts.AuthenticatorDescription.staticClass, _toString96)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel97; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.AuthenticatorDescription)) 
				@__env.CallVoidMethod(this, _writeToParcel97, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.accounts.AuthenticatorDescription.staticClass, _writeToParcel97, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents98; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accounts.AuthenticatorDescription)) 
				return @__env.CallIntMethod(this, _describeContents98); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.accounts.AuthenticatorDescription.staticClass, _describeContents98); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newKey99; 
		public static android.accounts.AuthenticatorDescription newKey(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.accounts.AuthenticatorDescription>(@__env, @__env.CallStaticObjectMethodPtr(android.accounts.AuthenticatorDescription.staticClass, _newKey99, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AuthenticatorDescription100; 
		public AuthenticatorDescription(java.lang.String arg0, java.lang.String arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.AuthenticatorDescription.staticClass, _AuthenticatorDescription100, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _type101; 
		public java.lang.String type
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _labelId102; 
		public int labelId
		{ 
			get 
			{ 
				return default(int); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _iconId103; 
		public int iconId
		{ 
			get 
			{ 
				return default(int); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _smallIconId104; 
		public int smallIconId
		{ 
			get 
			{ 
				return default(int); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _accountPreferencesId105; 
		public int accountPreferencesId
		{ 
			get 
			{ 
				return default(int); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _packageName106; 
		public java.lang.String packageName
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR107; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.accounts.AuthenticatorDescription.staticClass = @__class; 
			global::android.accounts.AuthenticatorDescription._hashCode94 = @__env.GetMethodID(global::android.accounts.AuthenticatorDescription.staticClass, "hashCode", "()I"); 
			global::android.accounts.AuthenticatorDescription._equals95 = @__env.GetMethodID(global::android.accounts.AuthenticatorDescription.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.accounts.AuthenticatorDescription._toString96 = @__env.GetMethodID(global::android.accounts.AuthenticatorDescription.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.accounts.AuthenticatorDescription._writeToParcel97 = @__env.GetMethodID(global::android.accounts.AuthenticatorDescription.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.accounts.AuthenticatorDescription._describeContents98 = @__env.GetMethodID(global::android.accounts.AuthenticatorDescription.staticClass, "describeContents", "()I"); 
			global::android.accounts.AuthenticatorDescription._newKey99 = @__env.GetStaticMethodID(global::android.accounts.AuthenticatorDescription.staticClass, "newKey", "(Ljava/lang/String;)Landroid/accounts/AuthenticatorDescription;"); 
			global::android.accounts.AuthenticatorDescription._AuthenticatorDescription100 = @__env.GetMethodID(global::android.accounts.AuthenticatorDescription.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;IIII)V"); 
		} 
	} 
} 
