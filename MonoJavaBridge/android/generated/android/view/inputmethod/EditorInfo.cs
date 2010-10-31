namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EditorInfo : java.lang.Object, android.text.InputType, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EditorInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.EditorInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.view.inputmethod.EditorInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.EditorInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.view.inputmethod.EditorInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.EditorInfo.staticClass, "describeContents", "()I", ref global::android.view.inputmethod.EditorInfo._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public EditorInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.EditorInfo._m3.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.EditorInfo._m3 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._m3);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _inputType5911;
		public int inputType
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _inputType5911);
			}
			set
			{
			}
		}
		public static int IME_MASK_ACTION
		{
			get
			{
				return 255;
			}
		}
		public static int IME_ACTION_UNSPECIFIED
		{
			get
			{
				return 0;
			}
		}
		public static int IME_ACTION_NONE
		{
			get
			{
				return 1;
			}
		}
		public static int IME_ACTION_GO
		{
			get
			{
				return 2;
			}
		}
		public static int IME_ACTION_SEARCH
		{
			get
			{
				return 3;
			}
		}
		public static int IME_ACTION_SEND
		{
			get
			{
				return 4;
			}
		}
		public static int IME_ACTION_NEXT
		{
			get
			{
				return 5;
			}
		}
		public static int IME_ACTION_DONE
		{
			get
			{
				return 6;
			}
		}
		public static int IME_FLAG_NO_EXTRACT_UI
		{
			get
			{
				return 268435456;
			}
		}
		public static int IME_FLAG_NO_ACCESSORY_ACTION
		{
			get
			{
				return 536870912;
			}
		}
		public static int IME_FLAG_NO_ENTER_ACTION
		{
			get
			{
				return 1073741824;
			}
		}
		public static int IME_NULL
		{
			get
			{
				return 0;
			}
		}
		internal static global::MonoJavaBridge.FieldId _imeOptions5924;
		public int imeOptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _imeOptions5924);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _privateImeOptions5925;
		public global::java.lang.String privateImeOptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _privateImeOptions5925)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _actionLabel5926;
		public global::java.lang.CharSequence actionLabel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _actionLabel5926)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _actionId5927;
		public int actionId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _actionId5927);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initialSelStart5928;
		public int initialSelStart
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _initialSelStart5928);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initialSelEnd5929;
		public int initialSelEnd
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _initialSelEnd5929);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initialCapsMode5930;
		public int initialCapsMode
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _initialCapsMode5930);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hintText5931;
		public global::java.lang.CharSequence hintText
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _hintText5931)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _label5932;
		public global::java.lang.CharSequence label
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _label5932)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageName5933;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName5933)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _fieldId5934;
		public int fieldId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _fieldId5934);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _fieldName5935;
		public global::java.lang.String fieldName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _fieldName5935)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _extras5936;
		public global::android.os.Bundle extras
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.GetObjectField(this.JvmHandle, _extras5936)) as android.os.Bundle;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR5937;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.inputmethod.EditorInfo.staticClass, _CREATOR5937)) as android.os.Parcelable_Creator;
			}
		}
		static EditorInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.EditorInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/EditorInfo"));
			global::android.view.inputmethod.EditorInfo._inputType5911 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "inputType", "I");
			global::android.view.inputmethod.EditorInfo._imeOptions5924 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "imeOptions", "I");
			global::android.view.inputmethod.EditorInfo._privateImeOptions5925 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "privateImeOptions", "Ljava/lang/String;");
			global::android.view.inputmethod.EditorInfo._actionLabel5926 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "actionLabel", "Ljava/lang/CharSequence;");
			global::android.view.inputmethod.EditorInfo._actionId5927 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "actionId", "I");
			global::android.view.inputmethod.EditorInfo._initialSelStart5928 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "initialSelStart", "I");
			global::android.view.inputmethod.EditorInfo._initialSelEnd5929 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "initialSelEnd", "I");
			global::android.view.inputmethod.EditorInfo._initialCapsMode5930 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "initialCapsMode", "I");
			global::android.view.inputmethod.EditorInfo._hintText5931 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "hintText", "Ljava/lang/CharSequence;");
			global::android.view.inputmethod.EditorInfo._label5932 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "label", "Ljava/lang/CharSequence;");
			global::android.view.inputmethod.EditorInfo._packageName5933 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "packageName", "Ljava/lang/String;");
			global::android.view.inputmethod.EditorInfo._fieldId5934 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "fieldId", "I");
			global::android.view.inputmethod.EditorInfo._fieldName5935 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "fieldName", "Ljava/lang/String;");
			global::android.view.inputmethod.EditorInfo._extras5936 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "extras", "Landroid/os/Bundle;");
			global::android.view.inputmethod.EditorInfo._CREATOR5937 = @__env.GetStaticFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
