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
		internal static global::MonoJavaBridge.MethodId _equals53;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.accounts.Account._equals53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.accounts.Account.staticClass, global::android.accounts.Account._equals53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString54;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.Account._toString54)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.Account.staticClass, global::android.accounts.Account._toString54)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode55;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.accounts.Account._hashCode55);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.accounts.Account.staticClass, global::android.accounts.Account._hashCode55);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel56;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.Account._writeToParcel56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.Account.staticClass, global::android.accounts.Account._writeToParcel56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents57;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.accounts.Account._describeContents57);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.accounts.Account.staticClass, global::android.accounts.Account._describeContents57);
		}
		internal static global::MonoJavaBridge.MethodId _Account58;
		public Account(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.Account.staticClass, global::android.accounts.Account._Account58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Account59;
		public Account(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.Account.staticClass, global::android.accounts.Account._Account59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _name60;
		public global::java.lang.String name
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _type61;
		public global::java.lang.String type
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR62;
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
			global::android.accounts.Account.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/Account"));
			global::android.accounts.Account._equals53 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.accounts.Account._toString54 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "toString", "()Ljava/lang/String;");
			global::android.accounts.Account._hashCode55 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "hashCode", "()I");
			global::android.accounts.Account._writeToParcel56 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.accounts.Account._describeContents57 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "describeContents", "()I");
			global::android.accounts.Account._Account58 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.accounts.Account._Account59 = @__env.GetMethodIDNoThrow(global::android.accounts.Account.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
