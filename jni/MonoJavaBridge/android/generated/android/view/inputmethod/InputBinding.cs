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
		internal static global::MonoJavaBridge.MethodId _toString10696;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding._toString10696)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._toString10696)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel10697;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding._writeToParcel10697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._writeToParcel10697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents10698;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding._describeContents10698);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._describeContents10698);
		}
		public new global::android.view.inputmethod.InputConnection Connection
		{
			get
			{
				return getConnection();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConnection10699;
		public global::android.view.inputmethod.InputConnection getConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding._getConnection10699)) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._getConnection10699)) as android.view.inputmethod.InputConnection;
		}
		public new global::android.os.IBinder ConnectionToken
		{
			get
			{
				return getConnectionToken();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionToken10700;
		public global::android.os.IBinder getConnectionToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding._getConnectionToken10700)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._getConnectionToken10700)) as android.os.IBinder;
		}
		public new int Uid
		{
			get
			{
				return getUid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUid10701;
		public int getUid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding._getUid10701);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._getUid10701);
		}
		public new int Pid
		{
			get
			{
				return getPid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPid10702;
		public int getPid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding._getPid10702);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._getPid10702);
		}
		internal static global::MonoJavaBridge.MethodId _InputBinding10703;
		public InputBinding(android.view.inputmethod.InputConnection arg0, android.os.IBinder arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._InputBinding10703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputBinding10704;
		public InputBinding(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.InputBinding arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._InputBinding10704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR10705;
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
			global::android.view.inputmethod.InputBinding.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputBinding"));
			global::android.view.inputmethod.InputBinding._toString10696 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.inputmethod.InputBinding._writeToParcel10697 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.InputBinding._describeContents10698 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.InputBinding._getConnection10699 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "getConnection", "()Landroid/view/inputmethod/InputConnection;");
			global::android.view.inputmethod.InputBinding._getConnectionToken10700 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "getConnectionToken", "()Landroid/os/IBinder;");
			global::android.view.inputmethod.InputBinding._getUid10701 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "getUid", "()I");
			global::android.view.inputmethod.InputBinding._getPid10702 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "getPid", "()I");
			global::android.view.inputmethod.InputBinding._InputBinding10703 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "<init>", "(Landroid/view/inputmethod/InputConnection;Landroid/os/IBinder;II)V");
			global::android.view.inputmethod.InputBinding._InputBinding10704 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputBinding.staticClass, "<init>", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/InputBinding;)V");
		}
	}
}
