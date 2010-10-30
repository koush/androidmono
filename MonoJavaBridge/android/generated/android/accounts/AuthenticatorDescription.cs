namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AuthenticatorDescription : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AuthenticatorDescription(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals1362;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._equals1362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString1363;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._toString1363)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode1364;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._hashCode1364);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1365;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._writeToParcel1365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1366;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._describeContents1366);
		}
		internal static global::MonoJavaBridge.MethodId _newKey1367;
		public static global::android.accounts.AuthenticatorDescription newKey(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._newKey1367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.accounts.AuthenticatorDescription;
		}
		internal static global::MonoJavaBridge.MethodId _AuthenticatorDescription1368;
		public AuthenticatorDescription(java.lang.String arg0, java.lang.String arg1, int arg2, int arg3, int arg4, int arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._AuthenticatorDescription1368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _type1369;
		public global::java.lang.String type
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _type1369)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _labelId1370;
		public int labelId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _labelId1370);
			}
		}
		internal static global::MonoJavaBridge.FieldId _iconId1371;
		public int iconId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _iconId1371);
			}
		}
		internal static global::MonoJavaBridge.FieldId _smallIconId1372;
		public int smallIconId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _smallIconId1372);
			}
		}
		internal static global::MonoJavaBridge.FieldId _accountPreferencesId1373;
		public int accountPreferencesId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _accountPreferencesId1373);
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageName1374;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName1374)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1375;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.accounts.AuthenticatorDescription.staticClass, _CREATOR1375)) as android.os.Parcelable_Creator;
			}
		}
		static AuthenticatorDescription()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AuthenticatorDescription.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AuthenticatorDescription"));
			global::android.accounts.AuthenticatorDescription._equals1362 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.accounts.AuthenticatorDescription._toString1363 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "toString", "()Ljava/lang/String;");
			global::android.accounts.AuthenticatorDescription._hashCode1364 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "hashCode", "()I");
			global::android.accounts.AuthenticatorDescription._writeToParcel1365 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.accounts.AuthenticatorDescription._describeContents1366 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "describeContents", "()I");
			global::android.accounts.AuthenticatorDescription._newKey1367 = @__env.GetStaticMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "newKey", "(Ljava/lang/String;)Landroid/accounts/AuthenticatorDescription;");
			global::android.accounts.AuthenticatorDescription._AuthenticatorDescription1368 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;IIII)V");
			global::android.accounts.AuthenticatorDescription._type1369 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "type", "Ljava/lang/String;");
			global::android.accounts.AuthenticatorDescription._labelId1370 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "labelId", "I");
			global::android.accounts.AuthenticatorDescription._iconId1371 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "iconId", "I");
			global::android.accounts.AuthenticatorDescription._smallIconId1372 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "smallIconId", "I");
			global::android.accounts.AuthenticatorDescription._accountPreferencesId1373 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "accountPreferencesId", "I");
			global::android.accounts.AuthenticatorDescription._packageName1374 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "packageName", "Ljava/lang/String;");
			global::android.accounts.AuthenticatorDescription._CREATOR1375 = @__env.GetStaticFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
