namespace android.accounts
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AuthenticatorDescription : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static AuthenticatorDescription()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.accounts.AuthenticatorDescription), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode100;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.accounts.AuthenticatorDescription._hashCode100);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._hashCode100);
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals101;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.accounts.AuthenticatorDescription._equals101, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._equals101, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString102;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.AuthenticatorDescription._toString102));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._toString102));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel103;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.accounts.AuthenticatorDescription._writeToParcel103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._writeToParcel103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents104;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.accounts.AuthenticatorDescription._describeContents104);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._describeContents104);
		}
		internal static global::net.sf.jni4net.jni.MethodId _newKey105;
		public static global::android.accounts.AuthenticatorDescription newKey(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.accounts.AuthenticatorDescription>(@__env, @__env.CallStaticObjectMethodPtr(android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._newKey105, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AuthenticatorDescription106;
		public AuthenticatorDescription(java.lang.String arg0, java.lang.String arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._AuthenticatorDescription106, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.FieldId _type107;
		public global::java.lang.String type
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _labelId108;
		public int labelId
		{
			get
			{
				return default(int);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _iconId109;
		public int iconId
		{
			get
			{
				return default(int);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _smallIconId110;
		public int smallIconId
		{
			get
			{
				return default(int);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _accountPreferencesId111;
		public int accountPreferencesId
		{
			get
			{
				return default(int);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _packageName112;
		public global::java.lang.String packageName
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR113;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.accounts.AuthenticatorDescription.staticClass = @__class;
			global::android.accounts.AuthenticatorDescription._hashCode100 = @__env.GetMethodID(global::android.accounts.AuthenticatorDescription.staticClass, "hashCode", "()I");
			global::android.accounts.AuthenticatorDescription._equals101 = @__env.GetMethodID(global::android.accounts.AuthenticatorDescription.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.accounts.AuthenticatorDescription._toString102 = @__env.GetMethodID(global::android.accounts.AuthenticatorDescription.staticClass, "toString", "()Ljava/lang/String;");
			global::android.accounts.AuthenticatorDescription._writeToParcel103 = @__env.GetMethodID(global::android.accounts.AuthenticatorDescription.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.accounts.AuthenticatorDescription._describeContents104 = @__env.GetMethodID(global::android.accounts.AuthenticatorDescription.staticClass, "describeContents", "()I");
			global::android.accounts.AuthenticatorDescription._newKey105 = @__env.GetStaticMethodID(global::android.accounts.AuthenticatorDescription.staticClass, "newKey", "(Ljava/lang/String;)Landroid/accounts/AuthenticatorDescription;");
			global::android.accounts.AuthenticatorDescription._AuthenticatorDescription106 = @__env.GetMethodID(global::android.accounts.AuthenticatorDescription.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;IIII)V");
		}
	}
}
