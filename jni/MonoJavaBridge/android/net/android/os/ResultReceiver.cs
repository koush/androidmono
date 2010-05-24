namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ResultReceiver : java.lang.Object, Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static ResultReceiver() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.ResultReceiver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _send5863; 
		public virtual void send(int arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.ResultReceiver)) 
				@__env.CallVoidMethod(this, _send5863, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.ResultReceiver.staticClass, _send5863, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel5864; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.ResultReceiver)) 
				@__env.CallVoidMethod(this, _writeToParcel5864, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.ResultReceiver.staticClass, _writeToParcel5864, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents5865; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.ResultReceiver)) 
				return @__env.CallIntMethod(this, _describeContents5865); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.ResultReceiver.staticClass, _describeContents5865); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceiveResult5866; 
		protected virtual void onReceiveResult(int arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.ResultReceiver)) 
				@__env.CallVoidMethod(this, _onReceiveResult5866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.ResultReceiver.staticClass, _onReceiveResult5866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ResultReceiver5867; 
		public ResultReceiver(android.os.Handler arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.ResultReceiver.staticClass, _ResultReceiver5867, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR5868; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.ResultReceiver.staticClass = @__class; 
			global::android.os.ResultReceiver._send5863 = @__env.GetMethodID(global::android.os.ResultReceiver.staticClass, "send", "(ILandroid/os/Bundle;)V"); 
			global::android.os.ResultReceiver._writeToParcel5864 = @__env.GetMethodID(global::android.os.ResultReceiver.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.os.ResultReceiver._describeContents5865 = @__env.GetMethodID(global::android.os.ResultReceiver.staticClass, "describeContents", "()I"); 
			global::android.os.ResultReceiver._onReceiveResult5866 = @__env.GetMethodID(global::android.os.ResultReceiver.staticClass, "onReceiveResult", "(ILandroid/os/Bundle;)V"); 
			global::android.os.ResultReceiver._ResultReceiver5867 = @__env.GetMethodID(global::android.os.ResultReceiver.staticClass, "<init>", "(Landroid/os/Handler;)V"); 
		} 
	} 
} 
