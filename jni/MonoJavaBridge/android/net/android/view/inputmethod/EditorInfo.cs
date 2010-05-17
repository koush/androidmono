namespace android.view.inputmethod 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class EditorInfo : java.lang.Object, android.text.InputType, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static EditorInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.inputmethod.EditorInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.inputmethod.EditorInfo(@__env); 
			} 
		} 
		protected EditorInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump8415; 
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.EditorInfo)) 
				@__env.CallVoidMethod(this, _dump8415, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.EditorInfo.staticClass, _dump8415, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8416; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.EditorInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel8416, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.EditorInfo.staticClass, _writeToParcel8416, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8417; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.EditorInfo)) 
				return @__env.CallIntMethod(this, _describeContents8417); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.inputmethod.EditorInfo.staticClass, _describeContents8417); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _EditorInfo8418; 
		public EditorInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.inputmethod.EditorInfo.staticClass, _EditorInfo8418, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _inputType8419; 
		public int inputType
		{ 
			get 
			{ 
				return default(int); 
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
		internal static global::net.sf.jni4net.jni.FieldId _imeOptions8420; 
		public int imeOptions
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _privateImeOptions8421; 
		public java.lang.String privateImeOptions
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _actionLabel8422; 
		public java.lang.CharSequence actionLabel
		{ 
			get 
			{ 
				return default(java.lang.CharSequence); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _actionId8423; 
		public int actionId
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _initialSelStart8424; 
		public int initialSelStart
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _initialSelEnd8425; 
		public int initialSelEnd
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _initialCapsMode8426; 
		public int initialCapsMode
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _hintText8427; 
		public java.lang.CharSequence hintText
		{ 
			get 
			{ 
				return default(java.lang.CharSequence); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _label8428; 
		public java.lang.CharSequence label
		{ 
			get 
			{ 
				return default(java.lang.CharSequence); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _packageName8429; 
		public java.lang.String packageName
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _fieldId8430; 
		public int fieldId
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _fieldName8431; 
		public java.lang.String fieldName
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _extras8432; 
		public android.os.Bundle extras
		{ 
			get 
			{ 
				return default(android.os.Bundle); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR8433; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.inputmethod.EditorInfo.staticClass = @__class; 
			global::android.view.inputmethod.EditorInfo._dump8415 = @__env.GetMethodID(global::android.view.inputmethod.EditorInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.view.inputmethod.EditorInfo._writeToParcel8416 = @__env.GetMethodID(global::android.view.inputmethod.EditorInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.view.inputmethod.EditorInfo._describeContents8417 = @__env.GetMethodID(global::android.view.inputmethod.EditorInfo.staticClass, "describeContents", "()I"); 
			global::android.view.inputmethod.EditorInfo._EditorInfo8418 = @__env.GetMethodID(global::android.view.inputmethod.EditorInfo.staticClass, "<init>", "()V"); 
		} 
	} 
} 
