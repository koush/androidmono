namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CompletionInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CompletionInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.inputmethod.CompletionInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.inputmethod.CompletionInfo._m0) as java.lang.String;
		}
		public new long Id
		{
			get
			{
				return getId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public long getId()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.inputmethod.CompletionInfo.staticClass, "getId", "()J", ref global::android.view.inputmethod.CompletionInfo._m1);
		}
		public new int Position
		{
			get
			{
				return getPosition();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public int getPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.CompletionInfo.staticClass, "getPosition", "()I", ref global::android.view.inputmethod.CompletionInfo._m2);
		}
		public new string Text
		{
			get
			{
				return getText().toString();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.lang.CharSequence getText()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.inputmethod.CompletionInfo.staticClass, "getText", "()Ljava/lang/CharSequence;", ref global::android.view.inputmethod.CompletionInfo._m3) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.CompletionInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.view.inputmethod.CompletionInfo._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.CompletionInfo.staticClass, "describeContents", "()I", ref global::android.view.inputmethod.CompletionInfo._m5);
		}
		public new string Label
		{
			get
			{
				return getLabel().toString();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.lang.CharSequence getLabel()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.inputmethod.CompletionInfo.staticClass, "getLabel", "()Ljava/lang/CharSequence;", ref global::android.view.inputmethod.CompletionInfo._m6) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public CompletionInfo(long arg0, int arg1, java.lang.CharSequence arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.CompletionInfo._m7.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.CompletionInfo._m7 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "<init>", "(JILjava/lang/CharSequence;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public CompletionInfo(long arg0, int arg1, java.lang.CharSequence arg2, java.lang.CharSequence arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.CompletionInfo._m8.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.CompletionInfo._m8 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "<init>", "(JILjava/lang/CharSequence;Ljava/lang/CharSequence;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.CompletionInfo.staticClass, global::android.view.inputmethod.CompletionInfo._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR5910;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.inputmethod.CompletionInfo.staticClass, _CREATOR5910)) as android.os.Parcelable_Creator;
			}
		}
		static CompletionInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.CompletionInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/CompletionInfo"));
			global::android.view.inputmethod.CompletionInfo._CREATOR5910 = @__env.GetStaticFieldIDNoThrow(global::android.view.inputmethod.CompletionInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
