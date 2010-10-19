namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CompletionInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CompletionInfo()
		{
			InitJNI();
		}
		internal CompletionInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString10648;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo._toString10648)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._toString10648)) as java.lang.String;
		}
		public new long Id
		{
			get
			{
				return getId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getId10649;
		public long getId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo._getId10649);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._getId10649);
		}
		public new int Position
		{
			get
			{
				return getPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPosition10650;
		public int getPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo._getPosition10650);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._getPosition10650);
		}
		public new string Text
		{
			get
			{
				return getText().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getText10651;
		public global::java.lang.CharSequence getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo._getText10651)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._getText10651)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel10652;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo._writeToParcel10652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._writeToParcel10652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents10653;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo._describeContents10653);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._describeContents10653);
		}
		public new string Label
		{
			get
			{
				return getLabel().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLabel10654;
		public global::java.lang.CharSequence getLabel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo._getLabel10654)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._getLabel10654)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _CompletionInfo10655;
		public CompletionInfo(long arg0, int arg1, java.lang.CharSequence arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._CompletionInfo10655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CompletionInfo10656;
		public CompletionInfo(long arg0, int arg1, java.lang.CharSequence arg2, java.lang.CharSequence arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._CompletionInfo10656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR10657;
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
			global::android.view.inputmethod.CompletionInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/CompletionInfo"));
			global::android.view.inputmethod.CompletionInfo._toString10648 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.inputmethod.CompletionInfo._getId10649 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "getId", "()J");
			global::android.view.inputmethod.CompletionInfo._getPosition10650 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "getPosition", "()I");
			global::android.view.inputmethod.CompletionInfo._getText10651 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.view.inputmethod.CompletionInfo._writeToParcel10652 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.CompletionInfo._describeContents10653 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.CompletionInfo._getLabel10654 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "getLabel", "()Ljava/lang/CharSequence;");
			global::android.view.inputmethod.CompletionInfo._CompletionInfo10655 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "<init>", "(JILjava/lang/CharSequence;)V");
			global::android.view.inputmethod.CompletionInfo._CompletionInfo10656 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "<init>", "(JILjava/lang/CharSequence;Ljava/lang/CharSequence;)V");
		}
	}
}
