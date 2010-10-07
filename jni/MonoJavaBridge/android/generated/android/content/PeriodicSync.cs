namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PeriodicSync : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static PeriodicSync()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.PeriodicSync), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.PeriodicSync(@__env);
			}
		}
		protected PeriodicSync(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals1643;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.PeriodicSync._equals1643, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._equals1643, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1644;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.PeriodicSync._writeToParcel1644, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._writeToParcel1644, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1645;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.PeriodicSync._describeContents1645);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._describeContents1645);
		}
		internal static global::net.sf.jni4net.jni.MethodId _PeriodicSync1646;
		public PeriodicSync(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, long arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.PeriodicSync.staticClass, global::android.content.PeriodicSync._PeriodicSync1646, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.FieldId _account1647;
		public global::android.accounts.Account account
		{
			get
			{
				return default(global::android.accounts.Account);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _authority1648;
		public global::java.lang.String authority
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _extras1649;
		public global::android.os.Bundle extras
		{
			get
			{
				return default(global::android.os.Bundle);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _period1650;
		public long period
		{
			get
			{
				return default(long);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1651;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.PeriodicSync.staticClass = @__class;
			global::android.content.PeriodicSync._equals1643 = @__env.GetMethodID(global::android.content.PeriodicSync.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.PeriodicSync._writeToParcel1644 = @__env.GetMethodID(global::android.content.PeriodicSync.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.PeriodicSync._describeContents1645 = @__env.GetMethodID(global::android.content.PeriodicSync.staticClass, "describeContents", "()I");
			global::android.content.PeriodicSync._PeriodicSync1646 = @__env.GetMethodID(global::android.content.PeriodicSync.staticClass, "<init>", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;J)V");
		}
	}
}
