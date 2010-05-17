namespace android.view.inputmethod 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class CompletionInfo : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static CompletionInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.inputmethod.CompletionInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.inputmethod.CompletionInfo(@__env); 
			} 
		} 
		internal CompletionInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString8405; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.CompletionInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString8405)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.CompletionInfo.staticClass, _toString8405)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getId8406; 
		public long getId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.CompletionInfo)) 
				return @__env.CallLongMethod(this, _getId8406); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.inputmethod.CompletionInfo.staticClass, _getId8406); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPosition8407; 
		public int getPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.CompletionInfo)) 
				return @__env.CallIntMethod(this, _getPosition8407); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.inputmethod.CompletionInfo.staticClass, _getPosition8407); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText8408; 
		public java.lang.CharSequence getText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.CompletionInfo)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getText8408)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.CompletionInfo.staticClass, _getText8408)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8409; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.CompletionInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel8409, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.CompletionInfo.staticClass, _writeToParcel8409, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8410; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.CompletionInfo)) 
				return @__env.CallIntMethod(this, _describeContents8410); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.inputmethod.CompletionInfo.staticClass, _describeContents8410); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLabel8411; 
		public java.lang.CharSequence getLabel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.CompletionInfo)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getLabel8411)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.CompletionInfo.staticClass, _getLabel8411)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CompletionInfo8412; 
		public CompletionInfo(long arg0, int arg1, java.lang.CharSequence arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.inputmethod.CompletionInfo.staticClass, _CompletionInfo8412, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CompletionInfo8413; 
		public CompletionInfo(long arg0, int arg1, java.lang.CharSequence arg2, java.lang.CharSequence arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.inputmethod.CompletionInfo.staticClass, _CompletionInfo8413, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR8414; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.inputmethod.CompletionInfo.staticClass = @__class; 
			global::android.view.inputmethod.CompletionInfo._toString8405 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.view.inputmethod.CompletionInfo._getId8406 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "getId", "()J"); 
			global::android.view.inputmethod.CompletionInfo._getPosition8407 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "getPosition", "()I"); 
			global::android.view.inputmethod.CompletionInfo._getText8408 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "getText", "()Ljava/lang/CharSequence;"); 
			global::android.view.inputmethod.CompletionInfo._writeToParcel8409 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.view.inputmethod.CompletionInfo._describeContents8410 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "describeContents", "()I"); 
			global::android.view.inputmethod.CompletionInfo._getLabel8411 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "getLabel", "()Ljava/lang/CharSequence;"); 
			global::android.view.inputmethod.CompletionInfo._CompletionInfo8412 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "<init>", "(JILjava/lang/CharSequence;)V"); 
			global::android.view.inputmethod.CompletionInfo._CompletionInfo8413 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "<init>", "(JILjava/lang/CharSequence;Ljava/lang/CharSequence;)V"); 
		} 
	} 
} 
