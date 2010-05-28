namespace android.view.inputmethod 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class InputBinding : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static InputBinding() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.inputmethod.InputBinding), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.inputmethod.InputBinding(@__env); 
			} 
		} 
		internal InputBinding(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString9096; 
		public sealed override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputBinding)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputBinding._toString9096)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._toString9096)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel9097; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputBinding)) 
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputBinding._writeToParcel9097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._writeToParcel9097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents9098; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputBinding)) 
				return @__env.CallIntMethod(this, global::android.view.inputmethod.InputBinding._describeContents9098); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._describeContents9098); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConnection9099; 
		public global::android.view.inputmethod.InputConnection getConnection() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputBinding)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputBinding._getConnection9099)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._getConnection9099)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConnectionToken9100; 
		public global::android.os.IBinder getConnectionToken() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputBinding)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputBinding._getConnectionToken9100)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._getConnectionToken9100)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUid9101; 
		public int getUid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputBinding)) 
				return @__env.CallIntMethod(this, global::android.view.inputmethod.InputBinding._getUid9101); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._getUid9101); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPid9102; 
		public int getPid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputBinding)) 
				return @__env.CallIntMethod(this, global::android.view.inputmethod.InputBinding._getPid9102); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._getPid9102); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputBinding9103; 
		public InputBinding(android.view.inputmethod.InputConnection arg0, android.os.IBinder arg1, int arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._InputBinding9103, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputBinding9104; 
		public InputBinding(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.InputBinding arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.inputmethod.InputBinding.staticClass, global::android.view.inputmethod.InputBinding._InputBinding9104, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR9105; 
		public static global::android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(global::android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.inputmethod.InputBinding.staticClass = @__class; 
			global::android.view.inputmethod.InputBinding._toString9096 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.view.inputmethod.InputBinding._writeToParcel9097 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.view.inputmethod.InputBinding._describeContents9098 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "describeContents", "()I"); 
			global::android.view.inputmethod.InputBinding._getConnection9099 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "getConnection", "()Landroid/view/inputmethod/InputConnection;"); 
			global::android.view.inputmethod.InputBinding._getConnectionToken9100 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "getConnectionToken", "()Landroid/os/IBinder;"); 
			global::android.view.inputmethod.InputBinding._getUid9101 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "getUid", "()I"); 
			global::android.view.inputmethod.InputBinding._getPid9102 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "getPid", "()I"); 
			global::android.view.inputmethod.InputBinding._InputBinding9103 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "<init>", "(Landroid/view/inputmethod/InputConnection;Landroid/os/IBinder;II)V"); 
			global::android.view.inputmethod.InputBinding._InputBinding9104 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "<init>", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/InputBinding;)V"); 
		} 
	} 
} 
