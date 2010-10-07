namespace android.view.inputmethod
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class CompletionInfo : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static CompletionInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.inputmethod.CompletionInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _toString9755;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.CompletionInfo._toString9755));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._toString9755));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getId9756;
		public long getId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.inputmethod.CompletionInfo._getId9756);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._getId9756);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPosition9757;
		public int getPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.inputmethod.CompletionInfo._getPosition9757);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._getPosition9757);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getText9758;
		public global::java.lang.CharSequence getText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.CompletionInfo._getText9758));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._getText9758));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel9759;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.CompletionInfo._writeToParcel9759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._writeToParcel9759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents9760;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.inputmethod.CompletionInfo._describeContents9760);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._describeContents9760);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLabel9761;
		public global::java.lang.CharSequence getLabel() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.CompletionInfo._getLabel9761));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._getLabel9761));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CompletionInfo9762;
		public CompletionInfo(long arg0, int arg1, java.lang.CharSequence arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._CompletionInfo9762, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CompletionInfo9763;
		public CompletionInfo(long arg0, int arg1, java.lang.CharSequence arg2, java.lang.CharSequence arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._CompletionInfo9763, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR9764;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.inputmethod.CompletionInfo.staticClass = @__class;
			global::android.view.inputmethod.CompletionInfo._toString9755 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.inputmethod.CompletionInfo._getId9756 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "getId", "()J");
			global::android.view.inputmethod.CompletionInfo._getPosition9757 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "getPosition", "()I");
			global::android.view.inputmethod.CompletionInfo._getText9758 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.view.inputmethod.CompletionInfo._writeToParcel9759 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.CompletionInfo._describeContents9760 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.CompletionInfo._getLabel9761 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "getLabel", "()Ljava/lang/CharSequence;");
			global::android.view.inputmethod.CompletionInfo._CompletionInfo9762 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "<init>", "(JILjava/lang/CharSequence;)V");
			global::android.view.inputmethod.CompletionInfo._CompletionInfo9763 = @__env.GetMethodID(global::android.view.inputmethod.CompletionInfo.staticClass, "<init>", "(JILjava/lang/CharSequence;Ljava/lang/CharSequence;)V");
		}
	}
}
