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
		internal static global::MonoJavaBridge.MethodId _toString15800;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo._toString15800)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._toString15800)) as java.lang.String;
		}
		public new long Id
		{
			get
			{
				return getId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getId15801;
		public long getId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo._getId15801);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._getId15801);
		}
		public new int Position
		{
			get
			{
				return getPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPosition15802;
		public int getPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo._getPosition15802);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._getPosition15802);
		}
		public new string Text
		{
			get
			{
				return getText().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getText15803;
		public global::java.lang.CharSequence getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo._getText15803)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._getText15803)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel15804;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo._writeToParcel15804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._writeToParcel15804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents15805;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo._describeContents15805);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._describeContents15805);
		}
		public new string Label
		{
			get
			{
				return getLabel().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLabel15806;
		public global::java.lang.CharSequence getLabel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo._getLabel15806)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._getLabel15806)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _CompletionInfo15807;
		public CompletionInfo(long arg0, int arg1, java.lang.CharSequence arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._CompletionInfo15807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CompletionInfo15808;
		public CompletionInfo(long arg0, int arg1, java.lang.CharSequence arg2, java.lang.CharSequence arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._CompletionInfo15808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR15809;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.inputmethod.CompletionInfo.staticClass, _CREATOR15809)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.CompletionInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/CompletionInfo"));
			global::android.view.inputmethod.CompletionInfo._toString15800 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.inputmethod.CompletionInfo._getId15801 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "getId", "()J");
			global::android.view.inputmethod.CompletionInfo._getPosition15802 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "getPosition", "()I");
			global::android.view.inputmethod.CompletionInfo._getText15803 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.view.inputmethod.CompletionInfo._writeToParcel15804 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.CompletionInfo._describeContents15805 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.CompletionInfo._getLabel15806 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "getLabel", "()Ljava/lang/CharSequence;");
			global::android.view.inputmethod.CompletionInfo._CompletionInfo15807 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "<init>", "(JILjava/lang/CharSequence;)V");
			global::android.view.inputmethod.CompletionInfo._CompletionInfo15808 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "<init>", "(JILjava/lang/CharSequence;Ljava/lang/CharSequence;)V");
			global::android.view.inputmethod.CompletionInfo._CREATOR15809 = @__env.GetStaticFieldIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
