namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExtractedText : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExtractedText(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.ExtractedText.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.view.inputmethod.ExtractedText._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.ExtractedText.staticClass, "describeContents", "()I", ref global::android.view.inputmethod.ExtractedText._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ExtractedText() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.ExtractedText._m2.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.ExtractedText._m2 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.ExtractedText.staticClass, global::android.view.inputmethod.ExtractedText._m2);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _text5938;
		public global::java.lang.CharSequence text
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _text5938)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _startOffset5939;
		public int startOffset
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _startOffset5939);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _partialStartOffset5940;
		public int partialStartOffset
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _partialStartOffset5940);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _partialEndOffset5941;
		public int partialEndOffset
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _partialEndOffset5941);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _selectionStart5942;
		public int selectionStart
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _selectionStart5942);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _selectionEnd5943;
		public int selectionEnd
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _selectionEnd5943);
			}
			set
			{
			}
		}
		public static int FLAG_SINGLE_LINE
		{
			get
			{
				return 1;
			}
		}
		public static int FLAG_SELECTING
		{
			get
			{
				return 2;
			}
		}
		internal static global::MonoJavaBridge.FieldId _flags5946;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags5946);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR5947;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.inputmethod.ExtractedText.staticClass, _CREATOR5947)) as android.os.Parcelable_Creator;
			}
		}
		static ExtractedText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.ExtractedText.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/ExtractedText"));
			global::android.view.inputmethod.ExtractedText._text5938 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "text", "Ljava/lang/CharSequence;");
			global::android.view.inputmethod.ExtractedText._startOffset5939 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "startOffset", "I");
			global::android.view.inputmethod.ExtractedText._partialStartOffset5940 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "partialStartOffset", "I");
			global::android.view.inputmethod.ExtractedText._partialEndOffset5941 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "partialEndOffset", "I");
			global::android.view.inputmethod.ExtractedText._selectionStart5942 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "selectionStart", "I");
			global::android.view.inputmethod.ExtractedText._selectionEnd5943 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "selectionEnd", "I");
			global::android.view.inputmethod.ExtractedText._flags5946 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "flags", "I");
			global::android.view.inputmethod.ExtractedText._CREATOR5947 = @__env.GetStaticFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
