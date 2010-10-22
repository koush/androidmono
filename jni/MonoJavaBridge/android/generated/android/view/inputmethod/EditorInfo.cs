namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EditorInfo : java.lang.Object, android.text.InputType, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EditorInfo()
		{
			InitJNI();
		}
		protected EditorInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _dump15729;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.EditorInfo._dump15729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._dump15729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel15730;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.EditorInfo._writeToParcel15730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._writeToParcel15730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents15731;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.EditorInfo._describeContents15731);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._describeContents15731);
		}
		internal static global::MonoJavaBridge.MethodId _EditorInfo15732;
		public EditorInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.EditorInfo.staticClass, global::android.view.inputmethod.EditorInfo._EditorInfo15732);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _inputType15733;
		public int inputType
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _inputType15733);
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
		internal static global::MonoJavaBridge.FieldId _imeOptions15746;
		public int imeOptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _imeOptions15746);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _privateImeOptions15747;
		public global::java.lang.String privateImeOptions
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _privateImeOptions15747)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _actionLabel15748;
		public global::java.lang.CharSequence actionLabel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _actionLabel15748)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _actionId15749;
		public int actionId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _actionId15749);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initialSelStart15750;
		public int initialSelStart
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _initialSelStart15750);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initialSelEnd15751;
		public int initialSelEnd
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _initialSelEnd15751);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _initialCapsMode15752;
		public int initialCapsMode
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _initialCapsMode15752);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hintText15753;
		public global::java.lang.CharSequence hintText
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _hintText15753)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _label15754;
		public global::java.lang.CharSequence label
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _label15754)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageName15755;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName15755)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _fieldId15756;
		public int fieldId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _fieldId15756);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _fieldName15757;
		public global::java.lang.String fieldName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _fieldName15757)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _extras15758;
		public global::android.os.Bundle extras
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.GetObjectField(this.JvmHandle, _extras15758)) as android.os.Bundle;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR15759;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.inputmethod.EditorInfo.staticClass, _CREATOR15759)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.EditorInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/EditorInfo"));
			global::android.view.inputmethod.EditorInfo._dump15729 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.view.inputmethod.EditorInfo._writeToParcel15730 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.inputmethod.EditorInfo._describeContents15731 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "describeContents", "()I");
			global::android.view.inputmethod.EditorInfo._EditorInfo15732 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "<init>", "()V");
			global::android.view.inputmethod.EditorInfo._inputType15733 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "inputType", "I");
			global::android.view.inputmethod.EditorInfo._imeOptions15746 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "imeOptions", "I");
			global::android.view.inputmethod.EditorInfo._privateImeOptions15747 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "privateImeOptions", "Ljava/lang/String;");
			global::android.view.inputmethod.EditorInfo._actionLabel15748 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "actionLabel", "Ljava/lang/CharSequence;");
			global::android.view.inputmethod.EditorInfo._actionId15749 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "actionId", "I");
			global::android.view.inputmethod.EditorInfo._initialSelStart15750 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "initialSelStart", "I");
			global::android.view.inputmethod.EditorInfo._initialSelEnd15751 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "initialSelEnd", "I");
			global::android.view.inputmethod.EditorInfo._initialCapsMode15752 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "initialCapsMode", "I");
			global::android.view.inputmethod.EditorInfo._hintText15753 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "hintText", "Ljava/lang/CharSequence;");
			global::android.view.inputmethod.EditorInfo._label15754 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "label", "Ljava/lang/CharSequence;");
			global::android.view.inputmethod.EditorInfo._packageName15755 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "packageName", "Ljava/lang/String;");
			global::android.view.inputmethod.EditorInfo._fieldId15756 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "fieldId", "I");
			global::android.view.inputmethod.EditorInfo._fieldName15757 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "fieldName", "Ljava/lang/String;");
			global::android.view.inputmethod.EditorInfo._extras15758 = @__env.GetFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "extras", "Landroid/os/Bundle;");
			global::android.view.inputmethod.EditorInfo._CREATOR15759 = @__env.GetStaticFieldIDNoThrow(global::android.view.inputmethod.EditorInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
