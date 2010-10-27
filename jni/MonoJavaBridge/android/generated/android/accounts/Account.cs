namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Account : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Account()
		{
			InitJNI();
		}
		protected Account(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals1278;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.accounts.Account._equals1278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.accounts.Account.staticClass, global::android.accounts.Account._equals1278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString1279;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.Account._toString1279)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.Account.staticClass, global::android.accounts.Account._toString1279)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode1280;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.accounts.Account._hashCode1280);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.accounts.Account.staticClass, global::android.accounts.Account._hashCode1280);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1281;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.Account._writeToParcel1281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.Account.staticClass, global::android.accounts.Account._writeToParcel1281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1282;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.accounts.Account._describeContents1282);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.accounts.Account.staticClass, global::android.accounts.Account._describeContents1282);
		}
		internal static global::MonoJavaBridge.MethodId _Account1283;
		public Account(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.Account.staticClass, global::android.accounts.Account._Account1283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Account1284;
		public Account(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.Account.staticClass, global::android.accounts.Account._Account1284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _name1285;
		public global::java.lang.String name
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _name1285)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _type1286;
		public global::java.lang.String type
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _type1286)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1287;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.accounts.Account.staticClass, _CREATOR1287)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.Account.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/Account"));
			global::android.accounts.Account._equals1278 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.accounts.Account._toString1279 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "toString", "()Ljava/lang/String;");
			global::android.accounts.Account._hashCode1280 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "hashCode", "()I");
			global::android.accounts.Account._writeToParcel1281 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.accounts.Account._describeContents1282 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "describeContents", "()I");
			global::android.accounts.Account._Account1283 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.accounts.Account._Account1284 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.accounts.Account._name1285 = @__env.GetFieldIDNoThrow(global::android.accounts.Account.staticClass, "name", "Ljava/lang/String;");
			global::android.accounts.Account._type1286 = @__env.GetFieldIDNoThrow(global::android.accounts.Account.staticClass, "type", "Ljava/lang/String;");
			global::android.accounts.Account._CREATOR1287 = @__env.GetStaticFieldIDNoThrow(global::android.accounts.Account.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
