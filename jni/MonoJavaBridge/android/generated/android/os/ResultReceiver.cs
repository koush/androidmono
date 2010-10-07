namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ResultReceiver : java.lang.Object, Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static ResultReceiver()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.ResultReceiver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.os.ResultReceiver(@__env);
			}
		}
		protected ResultReceiver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _send6442;
		public virtual void send(int arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.ResultReceiver._send6442, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._send6442, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6443;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.ResultReceiver._writeToParcel6443, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._writeToParcel6443, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents6444;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.ResultReceiver._describeContents6444);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._describeContents6444);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onReceiveResult6445;
		protected virtual void onReceiveResult(int arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.ResultReceiver._onReceiveResult6445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._onReceiveResult6445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ResultReceiver6446;
		public ResultReceiver(android.os.Handler arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._ResultReceiver6446, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR6447;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.ResultReceiver.staticClass = @__class;
			global::android.os.ResultReceiver._send6442 = @__env.GetMethodID(global::android.os.ResultReceiver.staticClass, "send", "(ILandroid/os/Bundle;)V");
			global::android.os.ResultReceiver._writeToParcel6443 = @__env.GetMethodID(global::android.os.ResultReceiver.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.ResultReceiver._describeContents6444 = @__env.GetMethodID(global::android.os.ResultReceiver.staticClass, "describeContents", "()I");
			global::android.os.ResultReceiver._onReceiveResult6445 = @__env.GetMethodID(global::android.os.ResultReceiver.staticClass, "onReceiveResult", "(ILandroid/os/Bundle;)V");
			global::android.os.ResultReceiver._ResultReceiver6446 = @__env.GetMethodID(global::android.os.ResultReceiver.staticClass, "<init>", "(Landroid/os/Handler;)V");
		}
	}
}
