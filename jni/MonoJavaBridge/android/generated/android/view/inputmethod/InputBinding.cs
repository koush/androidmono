namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class InputBinding : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputBinding()
		{
			InitJNI();
		}
		internal InputBinding(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString15781;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding._toString15781)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._toString15781)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel15782;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding._writeToParcel15782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._writeToParcel15782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents15783;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding._describeContents15783);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._describeContents15783);
		}
		public new global::android.view.inputmethod.InputConnection Connection
		{
			get
			{
				return getConnection();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConnection15784;
		public global::android.view.inputmethod.InputConnection getConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding._getConnection15784)) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._getConnection15784)) as android.view.inputmethod.InputConnection;
		}
		public new global::android.os.IBinder ConnectionToken
		{
			get
			{
				return getConnectionToken();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionToken15785;
		public global::android.os.IBinder getConnectionToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding._getConnectionToken15785)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._getConnectionToken15785)) as android.os.IBinder;
		}
		public new int Uid
		{
			get
			{
				return getUid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUid15786;
		public int getUid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding._getUid15786);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._getUid15786);
		}
		public new int Pid
		{
			get
			{
				return getPid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPid15787;
		public int getPid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding._getPid15787);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._getPid15787);
		}
		internal static global::MonoJavaBridge.MethodId _InputBinding15788;
		public InputBinding(android.view.inputmethod.InputConnection arg0, android.os.IBinder arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._InputBinding15788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputBinding15789;
		public InputBinding(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.InputBinding arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._InputBinding15789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR15790;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.inputmethod.InputBinding.staticClass, _CREATOR15790)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputBinding.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputBinding"));
			global::android.view.inputmethod.InputBinding._toString15781 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputBinding._writeToParcel15782 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.InputBinding._describeContents15783 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.InputBinding._getConnection15784 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "getConnection", "()Landroid/view/inputmethod/InputConnection;");
			global::android.view.inputmethod.InputBinding._getConnectionToken15785 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "getConnectionToken", "()Landroid/os/IBinder;");
			global::android.view.inputmethod.InputBinding._getUid15786 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "getUid", "()I");
			global::android.view.inputmethod.InputBinding._getPid15787 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "getPid", "()I");
			global::android.view.inputmethod.InputBinding._InputBinding15788 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "<init>", "(Landroid/view/inputmethod/InputConnection;Landroid/os/IBinder;II)V");
			global::android.view.inputmethod.InputBinding._InputBinding15789 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "<init>", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/InputBinding;)V");
			global::android.view.inputmethod.InputBinding._CREATOR15790 = @__env.GetStaticFieldIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
