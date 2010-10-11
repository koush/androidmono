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
		internal static global::MonoJavaBridge.MethodId _equals1737;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.PeriodicSync._equals1737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._equals1737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1738;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.PeriodicSync._writeToParcel1738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._writeToParcel1738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1739;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.PeriodicSync._describeContents1739);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._describeContents1739);
		}
		internal static global::MonoJavaBridge.MethodId _PeriodicSync1740;
		public PeriodicSync(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, long arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._PeriodicSync1740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _account1741;
		public global::android.accounts.Account account
		{
			get
			{
				return default(global::android.accounts.Account);
			}
		}
		internal static global::MonoJavaBridge.FieldId _authority1742;
		public global::java.lang.String authority
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _extras1743;
		public global::android.os.Bundle extras
		{
			get
			{
				return default(global::android.os.Bundle);
			}
		}
		internal static global::MonoJavaBridge.FieldId _period1744;
		public long period
		{
			get
			{
				return default(long);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1745;
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
			global::android.content.PeriodicSync.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/PeriodicSync"));
			global::android.content.PeriodicSync._equals1737 = @__env.GetMethodIDNoThrow(global::android.content.PeriodicSync.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.PeriodicSync._writeToParcel1738 = @__env.GetMethodIDNoThrow(global::android.content.PeriodicSync.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.PeriodicSync._describeContents1739 = @__env.GetMethodIDNoThrow(global::android.content.PeriodicSync.staticClass, "describeContents", "()I");
			global::android.content.PeriodicSync._PeriodicSync1740 = @__env.GetMethodIDNoThrow(global::android.content.PeriodicSync.staticClass, "<init>", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;J)V");
		}
	}
}
