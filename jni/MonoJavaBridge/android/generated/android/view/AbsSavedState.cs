namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class AbsSavedState : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static AbsSavedState()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.AbsSavedState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected AbsSavedState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7694;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.AbsSavedState._writeToParcel7694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.AbsSavedState.staticClass, global::android.view.AbsSavedState._writeToParcel7694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7695;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.AbsSavedState._describeContents7695);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.AbsSavedState.staticClass, global::android.view.AbsSavedState._describeContents7695);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSuperState7696;
		public virtual global::android.os.Parcelable getSuperState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.AbsSavedState._getSuperState7696));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.AbsSavedState.staticClass, global::android.view.AbsSavedState._getSuperState7696));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsSavedState7697;
		protected AbsSavedState(android.os.Parcelable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.AbsSavedState.staticClass, global::android.view.AbsSavedState._AbsSavedState7697, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsSavedState7698;
		protected AbsSavedState(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.AbsSavedState.staticClass, global::android.view.AbsSavedState._AbsSavedState7698, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _EMPTY_STATE7699;
		public static global::android.view.AbsSavedState EMPTY_STATE
		{
			get
			{
				return default(global::android.view.AbsSavedState);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR7700;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.AbsSavedState.staticClass = @__class;
			global::android.view.AbsSavedState._writeToParcel7694 = @__env.GetMethodID(global::android.view.AbsSavedState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.AbsSavedState._describeContents7695 = @__env.GetMethodID(global::android.view.AbsSavedState.staticClass, "describeContents", "()I");
			global::android.view.AbsSavedState._getSuperState7696 = @__env.GetMethodID(global::android.view.AbsSavedState.staticClass, "getSuperState", "()Landroid/os/Parcelable;");
			global::android.view.AbsSavedState._AbsSavedState7697 = @__env.GetMethodID(global::android.view.AbsSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V");
			global::android.view.AbsSavedState._AbsSavedState7698 = @__env.GetMethodID(global::android.view.AbsSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
