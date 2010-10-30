namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EditorInfo : java.lang.Object, android.text.InputType, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EditorInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _dump15810;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.EditorInfo._dump15810.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.EditorInfo._dump15810 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._dump15810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel15811;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.EditorInfo._writeToParcel15811.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.EditorInfo._writeToParcel15811 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._writeToParcel15811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents15812;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.EditorInfo._describeContents15812.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.EditorInfo._describeContents15812 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._describeContents15812);
		}
		internal static global::MonoJavaBridge.MethodId _EditorInfo15813;
		public EditorInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.EditorInfo._EditorInfo15813.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.EditorInfo._EditorInfo15813 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._EditorInfo15813);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _inputType15814;
		public int inputType
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _inputType15814);
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
		internal static global::MonoJavaBridge.FieldId _imeOptions15827;
		public int imeOptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _imeOptions15827);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _privateImeOptions15828;
		public global::java.lang.String privateImeOptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _privateImeOptions15828)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _actionLabel15829;
		public global::java.lang.CharSequence actionLabel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _actionLabel15829)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _actionId15830;
		public int actionId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _actionId15830);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initialSelStart15831;
		public int initialSelStart
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _initialSelStart15831);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initialSelEnd15832;
		public int initialSelEnd
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _initialSelEnd15832);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initialCapsMode15833;
		public int initialCapsMode
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _initialCapsMode15833);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hintText15834;
		public global::java.lang.CharSequence hintText
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _hintText15834)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _label15835;
		public global::java.lang.CharSequence label
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _label15835)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageName15836;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName15836)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _fieldId15837;
		public int fieldId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _fieldId15837);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _fieldName15838;
		public global::java.lang.String fieldName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _fieldName15838)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _extras15839;
		public global::android.os.Bundle extras
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.GetObjectField(this.JvmHandle, _extras15839)) as android.os.Bundle;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR15840;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.inputmethod.EditorInfo.staticClass, _CREATOR15840)) as android.os.Parcelable_Creator;
			}
		}
		static EditorInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.EditorInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/EditorInfo"));
			global::android.view.inputmethod.EditorInfo._inputType15814 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "inputType", "I");
			global::android.view.inputmethod.EditorInfo._imeOptions15827 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "imeOptions", "I");
			global::android.view.inputmethod.EditorInfo._privateImeOptions15828 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "privateImeOptions", "Ljava/lang/String;");
			global::android.view.inputmethod.EditorInfo._actionLabel15829 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "actionLabel", "Ljava/lang/CharSequence;");
			global::android.view.inputmethod.EditorInfo._actionId15830 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "actionId", "I");
			global::android.view.inputmethod.EditorInfo._initialSelStart15831 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "initialSelStart", "I");
			global::android.view.inputmethod.EditorInfo._initialSelEnd15832 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "initialSelEnd", "I");
			global::android.view.inputmethod.EditorInfo._initialCapsMode15833 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "initialCapsMode", "I");
			global::android.view.inputmethod.EditorInfo._hintText15834 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "hintText", "Ljava/lang/CharSequence;");
			global::android.view.inputmethod.EditorInfo._label15835 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "label", "Ljava/lang/CharSequence;");
			global::android.view.inputmethod.EditorInfo._packageName15836 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "packageName", "Ljava/lang/String;");
			global::android.view.inputmethod.EditorInfo._fieldId15837 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "fieldId", "I");
			global::android.view.inputmethod.EditorInfo._fieldName15838 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "fieldName", "Ljava/lang/String;");
			global::android.view.inputmethod.EditorInfo._extras15839 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "extras", "Landroid/os/Bundle;");
			global::android.view.inputmethod.EditorInfo._CREATOR15840 = @__env.GetStaticFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
