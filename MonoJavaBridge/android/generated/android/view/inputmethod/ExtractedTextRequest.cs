namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExtractedTextRequest : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExtractedTextRequest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.ExtractedTextRequest.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.view.inputmethod.ExtractedTextRequest._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.ExtractedTextRequest.staticClass, "describeContents", "()I", ref global::android.view.inputmethod.ExtractedTextRequest._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ExtractedTextRequest() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.ExtractedTextRequest._m2.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.ExtractedTextRequest._m2 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.ExtractedTextRequest.staticClass, global::android.view.inputmethod.ExtractedTextRequest._m2);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _token5948;
		public int token
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _token5948);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _flags5949;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags5949);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hintMaxLines5950;
		public int hintMaxLines
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _hintMaxLines5950);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hintMaxChars5951;
		public int hintMaxChars
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _hintMaxChars5951);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR5952;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.inputmethod.ExtractedTextRequest.staticClass, _CREATOR5952)) as android.os.Parcelable_Creator;
			}
		}
		static ExtractedTextRequest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.ExtractedTextRequest.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/ExtractedTextRequest"));
			global::android.view.inputmethod.ExtractedTextRequest._token5948 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "token", "I");
			global::android.view.inputmethod.ExtractedTextRequest._flags5949 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "flags", "I");
			global::android.view.inputmethod.ExtractedTextRequest._hintMaxLines5950 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "hintMaxLines", "I");
			global::android.view.inputmethod.ExtractedTextRequest._hintMaxChars5951 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "hintMaxChars", "I");
			global::android.view.inputmethod.ExtractedTextRequest._CREATOR5952 = @__env.GetStaticFieldIDNoThrow(global::android.view.inputmethod.ExtractedTextRequest.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
