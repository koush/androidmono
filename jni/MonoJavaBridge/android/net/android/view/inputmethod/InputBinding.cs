namespace android.view.inputmethod 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class InputBinding : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static InputBinding() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.inputmethod.InputBinding), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString8453; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputBinding)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString8453)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputBinding.staticClass, _toString8453)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8454; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputBinding)) 
				@__env.CallVoidMethod(this, _writeToParcel8454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputBinding.staticClass, _writeToParcel8454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8455; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputBinding)) 
				return @__env.CallIntMethod(this, _describeContents8455); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.inputmethod.InputBinding.staticClass, _describeContents8455); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConnection8456; 
		public android.view.inputmethod.InputConnection getConnection() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputBinding)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallObjectMethodPtr(this, _getConnection8456)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputBinding.staticClass, _getConnection8456)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConnectionToken8457; 
		public android.os.IBinder getConnectionToken() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputBinding)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, _getConnectionToken8457)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputBinding.staticClass, _getConnectionToken8457)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUid8458; 
		public int getUid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputBinding)) 
				return @__env.CallIntMethod(this, _getUid8458); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.inputmethod.InputBinding.staticClass, _getUid8458); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPid8459; 
		public int getPid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputBinding)) 
				return @__env.CallIntMethod(this, _getPid8459); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.inputmethod.InputBinding.staticClass, _getPid8459); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputBinding8460; 
		public InputBinding(android.view.inputmethod.InputConnection arg0, android.os.IBinder arg1, int arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.inputmethod.InputBinding.staticClass, _InputBinding8460, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputBinding8461; 
		public InputBinding(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.InputBinding arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.inputmethod.InputBinding.staticClass, _InputBinding8461, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR8462; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.inputmethod.InputBinding.staticClass = @__class; 
			global::android.view.inputmethod.InputBinding._toString8453 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.view.inputmethod.InputBinding._writeToParcel8454 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.view.inputmethod.InputBinding._describeContents8455 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "describeContents", "()I"); 
			global::android.view.inputmethod.InputBinding._getConnection8456 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "getConnection", "()Landroid/view/inputmethod/InputConnection;"); 
			global::android.view.inputmethod.InputBinding._getConnectionToken8457 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "getConnectionToken", "()Landroid/os/IBinder;"); 
			global::android.view.inputmethod.InputBinding._getUid8458 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "getUid", "()I"); 
			global::android.view.inputmethod.InputBinding._getPid8459 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "getPid", "()I"); 
			global::android.view.inputmethod.InputBinding._InputBinding8460 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "<init>", "(Landroid/view/inputmethod/InputConnection;Landroid/os/IBinder;II)V"); 
			global::android.view.inputmethod.InputBinding._InputBinding8461 = @__env.GetMethodID(global::android.view.inputmethod.InputBinding.staticClass, "<init>", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/InputBinding;)V"); 
		} 
	} 
} 
