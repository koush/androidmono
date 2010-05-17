namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbsSavedState : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static AbsSavedState() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.AbsSavedState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbsSavedState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7291; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.AbsSavedState)) 
				@__env.CallVoidMethod(this, _writeToParcel7291, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.AbsSavedState.staticClass, _writeToParcel7291, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7292; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.AbsSavedState)) 
				return @__env.CallIntMethod(this, _describeContents7292); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.AbsSavedState.staticClass, _describeContents7292); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSuperState7293; 
		public virtual android.os.Parcelable getSuperState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.AbsSavedState)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _getSuperState7293)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.AbsSavedState.staticClass, _getSuperState7293)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsSavedState7294; 
		protected AbsSavedState(android.os.Parcelable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.AbsSavedState.staticClass, _AbsSavedState7294, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsSavedState7295; 
		protected AbsSavedState(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.AbsSavedState.staticClass, _AbsSavedState7295, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _EMPTY_STATE7296; 
		public static android.view.AbsSavedState EMPTY_STATE
		{ 
			get 
			{ 
				return default(android.view.AbsSavedState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR7297; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.AbsSavedState.staticClass = @__class; 
			global::android.view.AbsSavedState._writeToParcel7291 = @__env.GetMethodID(global::android.view.AbsSavedState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.view.AbsSavedState._describeContents7292 = @__env.GetMethodID(global::android.view.AbsSavedState.staticClass, "describeContents", "()I"); 
			global::android.view.AbsSavedState._getSuperState7293 = @__env.GetMethodID(global::android.view.AbsSavedState.staticClass, "getSuperState", "()Landroid/os/Parcelable;"); 
			global::android.view.AbsSavedState._AbsSavedState7294 = @__env.GetMethodID(global::android.view.AbsSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V"); 
			global::android.view.AbsSavedState._AbsSavedState7295 = @__env.GetMethodID(global::android.view.AbsSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
