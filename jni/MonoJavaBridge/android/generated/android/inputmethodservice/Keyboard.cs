namespace android.inputmethodservice
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Keyboard : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Keyboard()
		{
			InitJNI();
		}
		protected Keyboard(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Key : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Key()
			{
				InitJNI();
			}
			protected Key(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onPressed6668;
			public virtual void onPressed() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key._onPressed6668);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._onPressed6668);
			}
			internal static global::MonoJavaBridge.MethodId _onReleased6669;
			public virtual void onReleased(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key._onReleased6669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._onReleased6669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isInside6670;
			public virtual bool isInside(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key._isInside6670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._isInside6670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _squaredDistanceFrom6671;
			public virtual int squaredDistanceFrom(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key._squaredDistanceFrom6671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._squaredDistanceFrom6671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new int[] CurrentDrawableState
			{
				get
				{
					return getCurrentDrawableState();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getCurrentDrawableState6672;
			public virtual int[] getCurrentDrawableState() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key._getCurrentDrawableState6672)) as int[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._getCurrentDrawableState6672)) as int[];
			}
			internal static global::MonoJavaBridge.MethodId _Key6673;
			public Key(android.inputmethodservice.Keyboard.Row arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._Key6673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _Key6674;
			public Key(android.content.res.Resources arg0, android.inputmethodservice.Keyboard.Row arg1, int arg2, int arg3, android.content.res.XmlResourceParser arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._Key6674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _codes6675;
			public int[] codes
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetObjectField(this.JvmHandle, _codes6675)) as int[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _label6676;
			public global::java.lang.CharSequence label
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _label6676)) as java.lang.CharSequence;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _icon6677;
			public global::android.graphics.drawable.Drawable icon
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _icon6677)) as android.graphics.drawable.Drawable;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _iconPreview6678;
			public global::android.graphics.drawable.Drawable iconPreview
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _iconPreview6678)) as android.graphics.drawable.Drawable;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _width6679;
			public int width
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _width6679);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _height6680;
			public int height
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _height6680);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _gap6681;
			public int gap
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _gap6681);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _sticky6682;
			public bool sticky
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _sticky6682);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _x6683;
			public int x
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _x6683);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _y6684;
			public int y
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _y6684);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _pressed6685;
			public bool pressed
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _pressed6685);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _on6686;
			public bool on
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _on6686);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _text6687;
			public global::java.lang.CharSequence text
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _text6687)) as java.lang.CharSequence;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _popupCharacters6688;
			public global::java.lang.CharSequence popupCharacters
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _popupCharacters6688)) as java.lang.CharSequence;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _edgeFlags6689;
			public int edgeFlags
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _edgeFlags6689);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _modifier6690;
			public bool modifier
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _modifier6690);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _popupResId6691;
			public int popupResId
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _popupResId6691);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _repeatable6692;
			public bool repeatable
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _repeatable6692);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.Keyboard.Key.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/Keyboard$Key"));
				global::android.inputmethodservice.Keyboard.Key._onPressed6668 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "onPressed", "()V");
				global::android.inputmethodservice.Keyboard.Key._onReleased6669 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "onReleased", "(Z)V");
				global::android.inputmethodservice.Keyboard.Key._isInside6670 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "isInside", "(II)Z");
				global::android.inputmethodservice.Keyboard.Key._squaredDistanceFrom6671 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "squaredDistanceFrom", "(II)I");
				global::android.inputmethodservice.Keyboard.Key._getCurrentDrawableState6672 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "getCurrentDrawableState", "()[I");
				global::android.inputmethodservice.Keyboard.Key._Key6673 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "<init>", "(Landroid/inputmethodservice/Keyboard$Row;)V");
				global::android.inputmethodservice.Keyboard.Key._Key6674 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandroid/content/res/XmlResourceParser;)V");
				global::android.inputmethodservice.Keyboard.Key._codes6675 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "codes", "[I");
				global::android.inputmethodservice.Keyboard.Key._label6676 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "label", "Ljava/lang/CharSequence;");
				global::android.inputmethodservice.Keyboard.Key._icon6677 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "icon", "Landroid/graphics/drawable/Drawable;");
				global::android.inputmethodservice.Keyboard.Key._iconPreview6678 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "iconPreview", "Landroid/graphics/drawable/Drawable;");
				global::android.inputmethodservice.Keyboard.Key._width6679 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "width", "I");
				global::android.inputmethodservice.Keyboard.Key._height6680 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "height", "I");
				global::android.inputmethodservice.Keyboard.Key._gap6681 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "gap", "I");
				global::android.inputmethodservice.Keyboard.Key._sticky6682 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "sticky", "Z");
				global::android.inputmethodservice.Keyboard.Key._x6683 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "x", "I");
				global::android.inputmethodservice.Keyboard.Key._y6684 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "y", "I");
				global::android.inputmethodservice.Keyboard.Key._pressed6685 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "pressed", "Z");
				global::android.inputmethodservice.Keyboard.Key._on6686 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "on", "Z");
				global::android.inputmethodservice.Keyboard.Key._text6687 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "text", "Ljava/lang/CharSequence;");
				global::android.inputmethodservice.Keyboard.Key._popupCharacters6688 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "popupCharacters", "Ljava/lang/CharSequence;");
				global::android.inputmethodservice.Keyboard.Key._edgeFlags6689 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "edgeFlags", "I");
				global::android.inputmethodservice.Keyboard.Key._modifier6690 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "modifier", "Z");
				global::android.inputmethodservice.Keyboard.Key._popupResId6691 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "popupResId", "I");
				global::android.inputmethodservice.Keyboard.Key._repeatable6692 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "repeatable", "Z");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Row : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Row()
			{
				InitJNI();
			}
			protected Row(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _Row6693;
			public Row(android.inputmethodservice.Keyboard arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Row.staticClass, global::android.inputmethodservice.Keyboard.Row._Row6693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _Row6694;
			public Row(android.content.res.Resources arg0, android.inputmethodservice.Keyboard arg1, android.content.res.XmlResourceParser arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Row.staticClass, global::android.inputmethodservice.Keyboard.Row._Row6694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _defaultWidth6695;
			public int defaultWidth
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _defaultWidth6695);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _defaultHeight6696;
			public int defaultHeight
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _defaultHeight6696);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _defaultHorizontalGap6697;
			public int defaultHorizontalGap
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _defaultHorizontalGap6697);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _verticalGap6698;
			public int verticalGap
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _verticalGap6698);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _rowEdgeFlags6699;
			public int rowEdgeFlags
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _rowEdgeFlags6699);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _mode6700;
			public int mode
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _mode6700);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.Keyboard.Row.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/Keyboard$Row"));
				global::android.inputmethodservice.Keyboard.Row._Row6693 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "<init>", "(Landroid/inputmethodservice/Keyboard;)V");
				global::android.inputmethodservice.Keyboard.Row._Row6694 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard;Landroid/content/res/XmlResourceParser;)V");
				global::android.inputmethodservice.Keyboard.Row._defaultWidth6695 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "defaultWidth", "I");
				global::android.inputmethodservice.Keyboard.Row._defaultHeight6696 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "defaultHeight", "I");
				global::android.inputmethodservice.Keyboard.Row._defaultHorizontalGap6697 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "defaultHorizontalGap", "I");
				global::android.inputmethodservice.Keyboard.Row._verticalGap6698 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "verticalGap", "I");
				global::android.inputmethodservice.Keyboard.Row._rowEdgeFlags6699 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "rowEdgeFlags", "I");
				global::android.inputmethodservice.Keyboard.Row._mode6700 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "mode", "I");
			}
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight6701;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getHeight6701);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getHeight6701);
		}
		public new global::java.util.List Keys
		{
			get
			{
				return getKeys();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeys6702;
		public virtual global::java.util.List getKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getKeys6702)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getKeys6702)) as java.util.List;
		}
		public new global::java.util.List ModifierKeys
		{
			get
			{
				return getModifierKeys();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getModifierKeys6703;
		public virtual global::java.util.List getModifierKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getModifierKeys6703)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getModifierKeys6703)) as java.util.List;
		}
		protected new int HorizontalGap
		{
			get
			{
				return getHorizontalGap();
			}
			set
			{
				setHorizontalGap(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalGap6704;
		protected virtual int getHorizontalGap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getHorizontalGap6704);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getHorizontalGap6704);
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalGap6705;
		protected virtual void setHorizontalGap(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._setHorizontalGap6705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setHorizontalGap6705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new int VerticalGap
		{
			get
			{
				return getVerticalGap();
			}
			set
			{
				setVerticalGap(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVerticalGap6706;
		protected virtual int getVerticalGap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getVerticalGap6706);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getVerticalGap6706);
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalGap6707;
		protected virtual void setVerticalGap(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._setVerticalGap6707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setVerticalGap6707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new int KeyHeight
		{
			get
			{
				return getKeyHeight();
			}
			set
			{
				setKeyHeight(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyHeight6708;
		protected virtual int getKeyHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getKeyHeight6708);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getKeyHeight6708);
		}
		internal static global::MonoJavaBridge.MethodId _setKeyHeight6709;
		protected virtual void setKeyHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._setKeyHeight6709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setKeyHeight6709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new int KeyWidth
		{
			get
			{
				return getKeyWidth();
			}
			set
			{
				setKeyWidth(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyWidth6710;
		protected virtual int getKeyWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getKeyWidth6710);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getKeyWidth6710);
		}
		internal static global::MonoJavaBridge.MethodId _setKeyWidth6711;
		protected virtual void setKeyWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._setKeyWidth6711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setKeyWidth6711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinWidth
		{
			get
			{
				return getMinWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinWidth6712;
		public virtual int getMinWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getMinWidth6712);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getMinWidth6712);
		}
		internal static global::MonoJavaBridge.MethodId _setShifted6713;
		public virtual bool setShifted(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._setShifted6713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setShifted6713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isShifted6714;
		public virtual bool isShifted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._isShifted6714);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._isShifted6714);
		}
		public new int ShiftKeyIndex
		{
			get
			{
				return getShiftKeyIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getShiftKeyIndex6715;
		public virtual int getShiftKeyIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getShiftKeyIndex6715);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getShiftKeyIndex6715);
		}
		internal static global::MonoJavaBridge.MethodId _getNearestKeys6716;
		public virtual int[] getNearestKeys(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getNearestKeys6716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getNearestKeys6716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _createRowFromXml6717;
		protected virtual global::android.inputmethodservice.Keyboard.Row createRowFromXml(android.content.res.Resources arg0, android.content.res.XmlResourceParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._createRowFromXml6717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.inputmethodservice.Keyboard.Row;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._createRowFromXml6717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.inputmethodservice.Keyboard.Row;
		}
		internal static global::MonoJavaBridge.MethodId _createKeyFromXml6718;
		protected virtual global::android.inputmethodservice.Keyboard.Key createKeyFromXml(android.content.res.Resources arg0, android.inputmethodservice.Keyboard.Row arg1, int arg2, int arg3, android.content.res.XmlResourceParser arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._createKeyFromXml6718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.inputmethodservice.Keyboard.Key;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._createKeyFromXml6718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.inputmethodservice.Keyboard.Key;
		}
		internal static global::MonoJavaBridge.MethodId _Keyboard6719;
		public Keyboard(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._Keyboard6719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Keyboard6720;
		public Keyboard(android.content.Context arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._Keyboard6720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Keyboard6721;
		public Keyboard(android.content.Context arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._Keyboard6721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		public static int EDGE_LEFT
		{
			get
			{
				return 1;
			}
		}
		public static int EDGE_RIGHT
		{
			get
			{
				return 2;
			}
		}
		public static int EDGE_TOP
		{
			get
			{
				return 4;
			}
		}
		public static int EDGE_BOTTOM
		{
			get
			{
				return 8;
			}
		}
		public static int KEYCODE_SHIFT
		{
			get
			{
				return -1;
			}
		}
		public static int KEYCODE_MODE_CHANGE
		{
			get
			{
				return -2;
			}
		}
		public static int KEYCODE_CANCEL
		{
			get
			{
				return -3;
			}
		}
		public static int KEYCODE_DONE
		{
			get
			{
				return -4;
			}
		}
		public static int KEYCODE_DELETE
		{
			get
			{
				return -5;
			}
		}
		public static int KEYCODE_ALT
		{
			get
			{
				return -6;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.Keyboard.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/Keyboard"));
			global::android.inputmethodservice.Keyboard._getHeight6701 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getHeight", "()I");
			global::android.inputmethodservice.Keyboard._getKeys6702 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getKeys", "()Ljava/util/List;");
			global::android.inputmethodservice.Keyboard._getModifierKeys6703 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getModifierKeys", "()Ljava/util/List;");
			global::android.inputmethodservice.Keyboard._getHorizontalGap6704 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getHorizontalGap", "()I");
			global::android.inputmethodservice.Keyboard._setHorizontalGap6705 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "setHorizontalGap", "(I)V");
			global::android.inputmethodservice.Keyboard._getVerticalGap6706 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getVerticalGap", "()I");
			global::android.inputmethodservice.Keyboard._setVerticalGap6707 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "setVerticalGap", "(I)V");
			global::android.inputmethodservice.Keyboard._getKeyHeight6708 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getKeyHeight", "()I");
			global::android.inputmethodservice.Keyboard._setKeyHeight6709 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "setKeyHeight", "(I)V");
			global::android.inputmethodservice.Keyboard._getKeyWidth6710 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getKeyWidth", "()I");
			global::android.inputmethodservice.Keyboard._setKeyWidth6711 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "setKeyWidth", "(I)V");
			global::android.inputmethodservice.Keyboard._getMinWidth6712 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getMinWidth", "()I");
			global::android.inputmethodservice.Keyboard._setShifted6713 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "setShifted", "(Z)Z");
			global::android.inputmethodservice.Keyboard._isShifted6714 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "isShifted", "()Z");
			global::android.inputmethodservice.Keyboard._getShiftKeyIndex6715 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getShiftKeyIndex", "()I");
			global::android.inputmethodservice.Keyboard._getNearestKeys6716 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getNearestKeys", "(II)[I");
			global::android.inputmethodservice.Keyboard._createRowFromXml6717 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "createRowFromXml", "(Landroid/content/res/Resources;Landroid/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Row;");
			global::android.inputmethodservice.Keyboard._createKeyFromXml6718 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "createKeyFromXml", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandroid/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Key;");
			global::android.inputmethodservice.Keyboard._Keyboard6719 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.inputmethodservice.Keyboard._Keyboard6720 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::android.inputmethodservice.Keyboard._Keyboard6721 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;ILjava/lang/CharSequence;II)V");
		}
	}
}
