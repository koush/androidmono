namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class InputBinding : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal InputBinding(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString15862;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.inputmethod.InputBinding.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.inputmethod.InputBinding._toString15862) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel15863;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputBinding.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.view.inputmethod.InputBinding._writeToParcel15863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents15864;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.InputBinding.staticClass, "describeContents", "()I", ref global::android.view.inputmethod.InputBinding._describeContents15864);
		}
		public new global::android.view.inputmethod.InputConnection Connection
		{
			get
			{
				return getConnection();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConnection15865;
		public global::android.view.inputmethod.InputConnection getConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.inputmethod.InputConnection>(this, global::android.view.inputmethod.InputBinding.staticClass, "getConnection", "()Landroid/view/inputmethod/InputConnection;", ref global::android.view.inputmethod.InputBinding._getConnection15865) as android.view.inputmethod.InputConnection;
		}
		public new global::android.os.IBinder ConnectionToken
		{
			get
			{
				return getConnectionToken();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionToken15866;
		public global::android.os.IBinder getConnectionToken()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.view.inputmethod.InputBinding.staticClass, "getConnectionToken", "()Landroid/os/IBinder;", ref global::android.view.inputmethod.InputBinding._getConnectionToken15866) as android.os.IBinder;
		}
		public new int Uid
		{
			get
			{
				return getUid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUid15867;
		public int getUid()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.InputBinding.staticClass, "getUid", "()I", ref global::android.view.inputmethod.InputBinding._getUid15867);
		}
		public new int Pid
		{
			get
			{
				return getPid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPid15868;
		public int getPid()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.InputBinding.staticClass, "getPid", "()I", ref global::android.view.inputmethod.InputBinding._getPid15868);
		}
		internal static global::MonoJavaBridge.MethodId _InputBinding15869;
		public InputBinding(android.view.inputmethod.InputConnection arg0, android.os.IBinder arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.InputBinding._InputBinding15869.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.InputBinding._InputBinding15869 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "<init>", "(Landroid/view/inputmethod/InputConnection;Landroid/os/IBinder;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._InputBinding15869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputBinding15870;
		public InputBinding(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.InputBinding arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.InputBinding._InputBinding15870.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.InputBinding._InputBinding15870 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "<init>", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/InputBinding;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._InputBinding15870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR15871;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.inputmethod.InputBinding.staticClass, _CREATOR15871)) as android.os.Parcelable_Creator;
			}
		}
		static InputBinding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputBinding.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputBinding"));
			global::android.view.inputmethod.InputBinding._CREATOR15871 = @__env.GetStaticFieldIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
