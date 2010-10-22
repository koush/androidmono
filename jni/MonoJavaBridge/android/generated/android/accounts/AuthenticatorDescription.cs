namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AuthenticatorDescription : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthenticatorDescription()
		{
			InitJNI();
		}
		protected AuthenticatorDescription(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals1361;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription._equals1361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._equals1361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString1362;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription._toString1362)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._toString1362)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode1363;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription._hashCode1363);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._hashCode1363);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1364;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription._writeToParcel1364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._writeToParcel1364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1365;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription._describeContents1365);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._describeContents1365);
		}
		internal static global::MonoJavaBridge.MethodId _newKey1366;
		public static global::android.accounts.AuthenticatorDescription newKey(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._newKey1366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.accounts.AuthenticatorDescription;
		}
		internal static global::MonoJavaBridge.MethodId _AuthenticatorDescription1367;
		public AuthenticatorDescription(java.lang.String arg0, java.lang.String arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._AuthenticatorDescription1367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _type1368;
		public global::java.lang.String type
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _type1368)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _labelId1369;
		public int labelId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _labelId1369);
			}
		}
		internal static global::MonoJavaBridge.FieldId _iconId1370;
		public int iconId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _iconId1370);
			}
		}
		internal static global::MonoJavaBridge.FieldId _smallIconId1371;
		public int smallIconId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _smallIconId1371);
			}
		}
		internal static global::MonoJavaBridge.FieldId _accountPreferencesId1372;
		public int accountPreferencesId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _accountPreferencesId1372);
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageName1373;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName1373)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1374;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.accounts.AuthenticatorDescription.staticClass, _CREATOR1374)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AuthenticatorDescription.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AuthenticatorDescription"));
			global::android.accounts.AuthenticatorDescription._equals1361 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.accounts.AuthenticatorDescription._toString1362 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "toString", "()Ljava/lang/String;");
			global::android.accounts.AuthenticatorDescription._hashCode1363 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "hashCode", "()I");
			global::android.accounts.AuthenticatorDescription._writeToParcel1364 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.accounts.AuthenticatorDescription._describeContents1365 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "describeContents", "()I");
			global::android.accounts.AuthenticatorDescription._newKey1366 = @__env.GetStaticMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "newKey", "(Ljava/lang/String;)Landroid/accounts/AuthenticatorDescription;");
			global::android.accounts.AuthenticatorDescription._AuthenticatorDescription1367 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;IIII)V");
			global::android.accounts.AuthenticatorDescription._type1368 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "type", "Ljava/lang/String;");
			global::android.accounts.AuthenticatorDescription._labelId1369 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "labelId", "I");
			global::android.accounts.AuthenticatorDescription._iconId1370 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "iconId", "I");
			global::android.accounts.AuthenticatorDescription._smallIconId1371 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "smallIconId", "I");
			global::android.accounts.AuthenticatorDescription._accountPreferencesId1372 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "accountPreferencesId", "I");
			global::android.accounts.AuthenticatorDescription._packageName1373 = @__env.GetFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "packageName", "Ljava/lang/String;");
			global::android.accounts.AuthenticatorDescription._CREATOR1374 = @__env.GetStaticFieldIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
