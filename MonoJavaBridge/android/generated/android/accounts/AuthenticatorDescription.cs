namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AuthenticatorDescription : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AuthenticatorDescription(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.accounts.AuthenticatorDescription.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.accounts.AuthenticatorDescription._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.accounts.AuthenticatorDescription.staticClass, "toString", "()Ljava/lang/String;", ref global::android.accounts.AuthenticatorDescription._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.accounts.AuthenticatorDescription.staticClass, "hashCode", "()I", ref global::android.accounts.AuthenticatorDescription._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AuthenticatorDescription.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.accounts.AuthenticatorDescription._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.accounts.AuthenticatorDescription.staticClass, "describeContents", "()I", ref global::android.accounts.AuthenticatorDescription._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::android.accounts.AuthenticatorDescription newKey(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AuthenticatorDescription._m5.native == global::System.IntPtr.Zero)
				global::android.accounts.AuthenticatorDescription._m5 = @__env.GetStaticMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "newKey", "(Ljava/lang/String;)Landroid/accounts/AuthenticatorDescription;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.accounts.AuthenticatorDescription;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public AuthenticatorDescription(java.lang.String arg0, java.lang.String arg1, int arg2, int arg3, int arg4, int arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.AuthenticatorDescription._m6.native == global::System.IntPtr.Zero)
				global::android.accounts.AuthenticatorDescription._m6 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;IIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _type1261;
		public global::java.lang.String type
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _type1261)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _labelId1262;
		public int labelId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _labelId1262);
			}
		}
		internal static global::MonoJavaBridge.FieldId _iconId1263;
		public int iconId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _iconId1263);
			}
		}
		internal static global::MonoJavaBridge.FieldId _smallIconId1264;
		public int smallIconId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _smallIconId1264);
			}
		}
		internal static global::MonoJavaBridge.FieldId _accountPreferencesId1265;
		public int accountPreferencesId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _accountPreferencesId1265);
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageName1266;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName1266)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1267;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.accounts.AuthenticatorDescription.staticClass, _CREATOR1267)) as android.os.Parcelable_Creator;
			}
		}
		static AuthenticatorDescription()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AuthenticatorDescription.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AuthenticatorDescription"));
			global::android.accounts.AuthenticatorDescription._type1261 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "type", "Ljava/lang/String;");
			global::android.accounts.AuthenticatorDescription._labelId1262 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "labelId", "I");
			global::android.accounts.AuthenticatorDescription._iconId1263 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "iconId", "I");
			global::android.accounts.AuthenticatorDescription._smallIconId1264 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "smallIconId", "I");
			global::android.accounts.AuthenticatorDescription._accountPreferencesId1265 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "accountPreferencesId", "I");
			global::android.accounts.AuthenticatorDescription._packageName1266 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "packageName", "Ljava/lang/String;");
			global::android.accounts.AuthenticatorDescription._CREATOR1267 = @__env.GetStaticFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
