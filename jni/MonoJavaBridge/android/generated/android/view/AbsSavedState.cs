namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.AbsSavedState_))]
	public abstract partial class AbsSavedState : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbsSavedState()
		{
			InitJNI();
		}
		protected AbsSavedState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13970;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.AbsSavedState._writeToParcel13970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.AbsSavedState.staticClass, global::android.view.AbsSavedState._writeToParcel13970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13971;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.AbsSavedState._describeContents13971);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.AbsSavedState.staticClass, global::android.view.AbsSavedState._describeContents13971);
		}
		internal static global::MonoJavaBridge.MethodId _getSuperState13972;
		public virtual global::android.os.Parcelable getSuperState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.AbsSavedState._getSuperState13972)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.AbsSavedState.staticClass, global::android.view.AbsSavedState._getSuperState13972)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _AbsSavedState13973;
		protected AbsSavedState(android.os.Parcelable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.AbsSavedState.staticClass, global::android.view.AbsSavedState._AbsSavedState13973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsSavedState13974;
		protected AbsSavedState(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.AbsSavedState.staticClass, global::android.view.AbsSavedState._AbsSavedState13974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY_STATE13975;
		public static global::android.view.AbsSavedState EMPTY_STATE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.view.AbsSavedState.staticClass, _EMPTY_STATE13975)) as android.view.AbsSavedState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR13976;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.AbsSavedState.staticClass, _CREATOR13976)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.AbsSavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/AbsSavedState"));
			global::android.view.AbsSavedState._writeToParcel13970 = @__env.GetMethodIDNoThrow(global::android.view.AbsSavedState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.AbsSavedState._describeContents13971 = @__env.GetMethodIDNoThrow(global::android.view.AbsSavedState.staticClass, "describeContents", "()I");
			global::android.view.AbsSavedState._getSuperState13972 = @__env.GetMethodIDNoThrow(global::android.view.AbsSavedState.staticClass, "getSuperState", "()Landroid/os/Parcelable;");
			global::android.view.AbsSavedState._AbsSavedState13973 = @__env.GetMethodIDNoThrow(global::android.view.AbsSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V");
			global::android.view.AbsSavedState._AbsSavedState13974 = @__env.GetMethodIDNoThrow(global::android.view.AbsSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.view.AbsSavedState._EMPTY_STATE13975 = @__env.GetStaticFieldIDNoThrow(global::android.view.AbsSavedState.staticClass, "EMPTY_STATE", "Landroid/view/AbsSavedState;");
			global::android.view.AbsSavedState._CREATOR13976 = @__env.GetStaticFieldIDNoThrow(global::android.view.AbsSavedState.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.AbsSavedState))]
	internal sealed partial class AbsSavedState_ : android.view.AbsSavedState
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbsSavedState_()
		{
			InitJNI();
		}
		internal AbsSavedState_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.AbsSavedState_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/AbsSavedState"));
		}
	}
}
