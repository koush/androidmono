namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Account : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Account(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.accounts.Account.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.accounts.Account._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.accounts.Account.staticClass, "toString", "()Ljava/lang/String;", ref global::android.accounts.Account._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.accounts.Account.staticClass, "hashCode", "()I", ref global::android.accounts.Account._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accounts.Account.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.accounts.Account._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.accounts.Account.staticClass, "describeContents", "()I", ref global::android.accounts.Account._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public Account(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.Account._m5.native == global::System.IntPtr.Zero)
				global::android.accounts.Account._m5 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.Account.staticClass, global::android.accounts.Account._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public Account(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.Account._m6.native == global::System.IntPtr.Zero)
				global::android.accounts.Account._m6 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.Account.staticClass, global::android.accounts.Account._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _name1231;
		public global::java.lang.String name
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _name1231)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _type1232;
		public global::java.lang.String type
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _type1232)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1233;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.accounts.Account.staticClass, _CREATOR1233)) as android.os.Parcelable_Creator;
			}
		}
		static Account()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.Account.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/Account"));
			global::android.accounts.Account._name1231 = @__env.GetFieldIDNoThrow(global::android.accounts.Account.staticClass, "name", "Ljava/lang/String;");
			global::android.accounts.Account._type1232 = @__env.GetFieldIDNoThrow(global::android.accounts.Account.staticClass, "type", "Ljava/lang/String;");
			global::android.accounts.Account._CREATOR1233 = @__env.GetStaticFieldIDNoThrow(global::android.accounts.Account.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
