namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PeriodicSync : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PeriodicSync()
		{
			InitJNI();
		}
		protected PeriodicSync(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals3475;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.PeriodicSync._equals3475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._equals3475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3476;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.PeriodicSync._writeToParcel3476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._writeToParcel3476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3477;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.PeriodicSync._describeContents3477);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._describeContents3477);
		}
		internal static global::MonoJavaBridge.MethodId _PeriodicSync3478;
		public PeriodicSync(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, long arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._PeriodicSync3478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _account3479;
		public global::android.accounts.Account account
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _account3479)) as android.accounts.Account;
			}
		}
		internal static global::MonoJavaBridge.FieldId _authority3480;
		public global::java.lang.String authority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _authority3480)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _extras3481;
		public global::android.os.Bundle extras
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _extras3481)) as android.os.Bundle;
			}
		}
		internal static global::MonoJavaBridge.FieldId _period3482;
		public long period
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _period3482);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3483;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.PeriodicSync.staticClass, _CREATOR3483)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.PeriodicSync.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/PeriodicSync"));
			global::android.content.PeriodicSync._equals3475 = @__env.GetMethodIDNoThrow(global::android.content.PeriodicSync.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.PeriodicSync._writeToParcel3476 = @__env.GetMethodIDNoThrow(global::android.content.PeriodicSync.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.PeriodicSync._describeContents3477 = @__env.GetMethodIDNoThrow(global::android.content.PeriodicSync.staticClass, "describeContents", "()I");
			global::android.content.PeriodicSync._PeriodicSync3478 = @__env.GetMethodIDNoThrow(global::android.content.PeriodicSync.staticClass, "<init>", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;J)V");
			global::android.content.PeriodicSync._account3479 = @__env.GetFieldIDNoThrow(global::android.content.PeriodicSync.staticClass, "account", "Landroid/accounts/Account;");
			global::android.content.PeriodicSync._authority3480 = @__env.GetFieldIDNoThrow(global::android.content.PeriodicSync.staticClass, "authority", "Ljava/lang/String;");
			global::android.content.PeriodicSync._extras3481 = @__env.GetFieldIDNoThrow(global::android.content.PeriodicSync.staticClass, "extras", "Landroid/os/Bundle;");
			global::android.content.PeriodicSync._period3482 = @__env.GetFieldIDNoThrow(global::android.content.PeriodicSync.staticClass, "period", "J");
			global::android.content.PeriodicSync._CREATOR3483 = @__env.GetStaticFieldIDNoThrow(global::android.content.PeriodicSync.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
