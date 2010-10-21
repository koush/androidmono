namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExtractedText : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExtractedText()
		{
			InitJNI();
		}
		protected ExtractedText(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel15760;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedText._writeToParcel15760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedText.staticClass, global::android.view.inputmethod.ExtractedText._writeToParcel15760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents15761;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedText._describeContents15761);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.ExtractedText.staticClass, global::android.view.inputmethod.ExtractedText._describeContents15761);
		}
		internal static global::MonoJavaBridge.MethodId _ExtractedText15762;
		public ExtractedText()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.ExtractedText.staticClass, global::android.view.inputmethod.ExtractedText._ExtractedText15762);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _text15763;
		public global::java.lang.CharSequence text
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _text15763)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _startOffset15764;
		public int startOffset
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _startOffset15764);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _partialStartOffset15765;
		public int partialStartOffset
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _partialStartOffset15765);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _partialEndOffset15766;
		public int partialEndOffset
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _partialEndOffset15766);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _selectionStart15767;
		public int selectionStart
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _selectionStart15767);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _selectionEnd15768;
		public int selectionEnd
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _selectionEnd15768);
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
		internal static global::MonoJavaBridge.FieldId _flags15771;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags15771);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR15772;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.inputmethod.ExtractedText.staticClass, _CREATOR15772)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.ExtractedText.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/ExtractedText"));
			global::android.view.inputmethod.ExtractedText._writeToParcel15760 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.ExtractedText._describeContents15761 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.ExtractedText._ExtractedText15762 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "<init>", "()V");
			global::android.view.inputmethod.ExtractedText._text15763 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "text", "Ljava/lang/CharSequence;");
			global::android.view.inputmethod.ExtractedText._startOffset15764 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "startOffset", "I");
			global::android.view.inputmethod.ExtractedText._partialStartOffset15765 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "partialStartOffset", "I");
			global::android.view.inputmethod.ExtractedText._partialEndOffset15766 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "partialEndOffset", "I");
			global::android.view.inputmethod.ExtractedText._selectionStart15767 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "selectionStart", "I");
			global::android.view.inputmethod.ExtractedText._selectionEnd15768 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "selectionEnd", "I");
			global::android.view.inputmethod.ExtractedText._flags15771 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "flags", "I");
			global::android.view.inputmethod.ExtractedText._CREATOR15772 = @__env.GetStaticFieldIDNoThrow(global::android.view.inputmethod.ExtractedText.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
