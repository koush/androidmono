namespace android.inputmethodservice
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Keyboard : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Keyboard(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Key : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Key(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onPressed6693;
			public virtual void onPressed()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._onPressed6693);
			}
			internal static global::MonoJavaBridge.MethodId _onReleased6694;
			public virtual void onReleased(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._onReleased6694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isInside6695;
			public virtual bool isInside(int arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._isInside6695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _squaredDistanceFrom6696;
			public virtual int squaredDistanceFrom(int arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._squaredDistanceFrom6696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new int[] CurrentDrawableState
			{
				get
				{
					return getCurrentDrawableState();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getCurrentDrawableState6697;
			public virtual int[] getCurrentDrawableState()
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._getCurrentDrawableState6697)) as int[];
			}
			internal static global::MonoJavaBridge.MethodId _Key6698;
			public Key(android.inputmethodservice.Keyboard.Row arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._Key6698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _Key6699;
			public Key(android.content.res.Resources arg0, android.inputmethodservice.Keyboard.Row arg1, int arg2, int arg3, android.content.res.XmlResourceParser arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._Key6699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _codes6700;
			public int[] codes
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetObjectField(this.JvmHandle, _codes6700)) as int[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _label6701;
			public global::java.lang.CharSequence label
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _label6701)) as java.lang.CharSequence;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _icon6702;
			public global::android.graphics.drawable.Drawable icon
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _icon6702)) as android.graphics.drawable.Drawable;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _iconPreview6703;
			public global::android.graphics.drawable.Drawable iconPreview
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _iconPreview6703)) as android.graphics.drawable.Drawable;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _width6704;
			public int width
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _width6704);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _height6705;
			public int height
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _height6705);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _gap6706;
			public int gap
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _gap6706);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _sticky6707;
			public bool sticky
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _sticky6707);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _x6708;
			public int x
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _x6708);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _y6709;
			public int y
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _y6709);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _pressed6710;
			public bool pressed
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _pressed6710);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _on6711;
			public bool on
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _on6711);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _text6712;
			public global::java.lang.CharSequence text
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _text6712)) as java.lang.CharSequence;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _popupCharacters6713;
			public global::java.lang.CharSequence popupCharacters
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _popupCharacters6713)) as java.lang.CharSequence;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _edgeFlags6714;
			public int edgeFlags
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _edgeFlags6714);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _modifier6715;
			public bool modifier
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _modifier6715);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _popupResId6716;
			public int popupResId
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _popupResId6716);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _repeatable6717;
			public bool repeatable
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _repeatable6717);
				}
				set
				{
				}
			}
			static Key()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.Keyboard.Key.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/Keyboard$Key"));
				global::android.inputmethodservice.Keyboard.Key._onPressed6693 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "onPressed", "()V");
				global::android.inputmethodservice.Keyboard.Key._onReleased6694 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "onReleased", "(Z)V");
				global::android.inputmethodservice.Keyboard.Key._isInside6695 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "isInside", "(II)Z");
				global::android.inputmethodservice.Keyboard.Key._squaredDistanceFrom6696 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "squaredDistanceFrom", "(II)I");
				global::android.inputmethodservice.Keyboard.Key._getCurrentDrawableState6697 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "getCurrentDrawableState", "()[I");
				global::android.inputmethodservice.Keyboard.Key._Key6698 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "<init>", "(Landroid/inputmethodservice/Keyboard$Row;)V");
				global::android.inputmethodservice.Keyboard.Key._Key6699 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandroid/content/res/XmlResourceParser;)V");
				global::android.inputmethodservice.Keyboard.Key._codes6700 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "codes", "[I");
				global::android.inputmethodservice.Keyboard.Key._label6701 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "label", "Ljava/lang/CharSequence;");
				global::android.inputmethodservice.Keyboard.Key._icon6702 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "icon", "Landroid/graphics/drawable/Drawable;");
				global::android.inputmethodservice.Keyboard.Key._iconPreview6703 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "iconPreview", "Landroid/graphics/drawable/Drawable;");
				global::android.inputmethodservice.Keyboard.Key._width6704 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "width", "I");
				global::android.inputmethodservice.Keyboard.Key._height6705 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "height", "I");
				global::android.inputmethodservice.Keyboard.Key._gap6706 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "gap", "I");
				global::android.inputmethodservice.Keyboard.Key._sticky6707 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "sticky", "Z");
				global::android.inputmethodservice.Keyboard.Key._x6708 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "x", "I");
				global::android.inputmethodservice.Keyboard.Key._y6709 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "y", "I");
				global::android.inputmethodservice.Keyboard.Key._pressed6710 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "pressed", "Z");
				global::android.inputmethodservice.Keyboard.Key._on6711 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "on", "Z");
				global::android.inputmethodservice.Keyboard.Key._text6712 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "text", "Ljava/lang/CharSequence;");
				global::android.inputmethodservice.Keyboard.Key._popupCharacters6713 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "popupCharacters", "Ljava/lang/CharSequence;");
				global::android.inputmethodservice.Keyboard.Key._edgeFlags6714 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "edgeFlags", "I");
				global::android.inputmethodservice.Keyboard.Key._modifier6715 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "modifier", "Z");
				global::android.inputmethodservice.Keyboard.Key._popupResId6716 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "popupResId", "I");
				global::android.inputmethodservice.Keyboard.Key._repeatable6717 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "repeatable", "Z");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Row : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Row(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _Row6718;
			public Row(android.inputmethodservice.Keyboard arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Row.staticClass, global::android.inputmethodservice.Keyboard.Row._Row6718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _Row6719;
			public Row(android.content.res.Resources arg0, android.inputmethodservice.Keyboard arg1, android.content.res.XmlResourceParser arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Row.staticClass, global::android.inputmethodservice.Keyboard.Row._Row6719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _defaultWidth6720;
			public int defaultWidth
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _defaultWidth6720);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _defaultHeight6721;
			public int defaultHeight
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _defaultHeight6721);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _defaultHorizontalGap6722;
			public int defaultHorizontalGap
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _defaultHorizontalGap6722);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _verticalGap6723;
			public int verticalGap
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _verticalGap6723);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _rowEdgeFlags6724;
			public int rowEdgeFlags
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _rowEdgeFlags6724);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _mode6725;
			public int mode
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _mode6725);
				}
				set
				{
				}
			}
			static Row()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.Keyboard.Row.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/Keyboard$Row"));
				global::android.inputmethodservice.Keyboard.Row._Row6718 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "<init>", "(Landroid/inputmethodservice/Keyboard;)V");
				global::android.inputmethodservice.Keyboard.Row._Row6719 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard;Landroid/content/res/XmlResourceParser;)V");
				global::android.inputmethodservice.Keyboard.Row._defaultWidth6720 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "defaultWidth", "I");
				global::android.inputmethodservice.Keyboard.Row._defaultHeight6721 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "defaultHeight", "I");
				global::android.inputmethodservice.Keyboard.Row._defaultHorizontalGap6722 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "defaultHorizontalGap", "I");
				global::android.inputmethodservice.Keyboard.Row._verticalGap6723 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "verticalGap", "I");
				global::android.inputmethodservice.Keyboard.Row._rowEdgeFlags6724 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "rowEdgeFlags", "I");
				global::android.inputmethodservice.Keyboard.Row._mode6725 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "mode", "I");
			}
			internal static void InitJNI()
			{
			}
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight6726;
		public virtual int getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getHeight6726);
		}
		public new global::java.util.List Keys
		{
			get
			{
				return getKeys();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeys6727;
		public virtual global::java.util.List getKeys()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getKeys6727)) as java.util.List;
		}
		public new global::java.util.List ModifierKeys
		{
			get
			{
				return getModifierKeys();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getModifierKeys6728;
		public virtual global::java.util.List getModifierKeys()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getModifierKeys6728)) as java.util.List;
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
		internal static global::MonoJavaBridge.MethodId _getHorizontalGap6729;
		protected virtual int getHorizontalGap()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getHorizontalGap6729);
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalGap6730;
		protected virtual void setHorizontalGap(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setHorizontalGap6730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getVerticalGap6731;
		protected virtual int getVerticalGap()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getVerticalGap6731);
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalGap6732;
		protected virtual void setVerticalGap(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setVerticalGap6732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getKeyHeight6733;
		protected virtual int getKeyHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getKeyHeight6733);
		}
		internal static global::MonoJavaBridge.MethodId _setKeyHeight6734;
		protected virtual void setKeyHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setKeyHeight6734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getKeyWidth6735;
		protected virtual int getKeyWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getKeyWidth6735);
		}
		internal static global::MonoJavaBridge.MethodId _setKeyWidth6736;
		protected virtual void setKeyWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setKeyWidth6736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinWidth
		{
			get
			{
				return getMinWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinWidth6737;
		public virtual int getMinWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getMinWidth6737);
		}
		public new bool Shifted
		{
			set
			{
				setShifted(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setShifted6738;
		public virtual bool setShifted(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setShifted6738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isShifted6739;
		public virtual bool isShifted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._isShifted6739);
		}
		public new int ShiftKeyIndex
		{
			get
			{
				return getShiftKeyIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getShiftKeyIndex6740;
		public virtual int getShiftKeyIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getShiftKeyIndex6740);
		}
		internal static global::MonoJavaBridge.MethodId _getNearestKeys6741;
		public virtual int[] getNearestKeys(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getNearestKeys6741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _createRowFromXml6742;
		protected virtual global::android.inputmethodservice.Keyboard.Row createRowFromXml(android.content.res.Resources arg0, android.content.res.XmlResourceParser arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._createRowFromXml6742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.inputmethodservice.Keyboard.Row;
		}
		internal static global::MonoJavaBridge.MethodId _createKeyFromXml6743;
		protected virtual global::android.inputmethodservice.Keyboard.Key createKeyFromXml(android.content.res.Resources arg0, android.inputmethodservice.Keyboard.Row arg1, int arg2, int arg3, android.content.res.XmlResourceParser arg4)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._createKeyFromXml6743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.inputmethodservice.Keyboard.Key;
		}
		internal static global::MonoJavaBridge.MethodId _Keyboard6744;
		public Keyboard(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._Keyboard6744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Keyboard6745;
		public Keyboard(android.content.Context arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._Keyboard6745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Keyboard6746;
		public Keyboard(android.content.Context arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._Keyboard6746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
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
		static Keyboard()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.Keyboard.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/Keyboard"));
			global::android.inputmethodservice.Keyboard._getHeight6726 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getHeight", "()I");
			global::android.inputmethodservice.Keyboard._getKeys6727 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getKeys", "()Ljava/util/List;");
			global::android.inputmethodservice.Keyboard._getModifierKeys6728 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getModifierKeys", "()Ljava/util/List;");
			global::android.inputmethodservice.Keyboard._getHorizontalGap6729 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getHorizontalGap", "()I");
			global::android.inputmethodservice.Keyboard._setHorizontalGap6730 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "setHorizontalGap", "(I)V");
			global::android.inputmethodservice.Keyboard._getVerticalGap6731 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getVerticalGap", "()I");
			global::android.inputmethodservice.Keyboard._setVerticalGap6732 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "setVerticalGap", "(I)V");
			global::android.inputmethodservice.Keyboard._getKeyHeight6733 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getKeyHeight", "()I");
			global::android.inputmethodservice.Keyboard._setKeyHeight6734 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "setKeyHeight", "(I)V");
			global::android.inputmethodservice.Keyboard._getKeyWidth6735 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getKeyWidth", "()I");
			global::android.inputmethodservice.Keyboard._setKeyWidth6736 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "setKeyWidth", "(I)V");
			global::android.inputmethodservice.Keyboard._getMinWidth6737 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getMinWidth", "()I");
			global::android.inputmethodservice.Keyboard._setShifted6738 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "setShifted", "(Z)Z");
			global::android.inputmethodservice.Keyboard._isShifted6739 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "isShifted", "()Z");
			global::android.inputmethodservice.Keyboard._getShiftKeyIndex6740 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getShiftKeyIndex", "()I");
			global::android.inputmethodservice.Keyboard._getNearestKeys6741 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getNearestKeys", "(II)[I");
			global::android.inputmethodservice.Keyboard._createRowFromXml6742 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "createRowFromXml", "(Landroid/content/res/Resources;Landroid/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Row;");
			global::android.inputmethodservice.Keyboard._createKeyFromXml6743 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "createKeyFromXml", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandroid/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Key;");
			global::android.inputmethodservice.Keyboard._Keyboard6744 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.inputmethodservice.Keyboard._Keyboard6745 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::android.inputmethodservice.Keyboard._Keyboard6746 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;ILjava/lang/CharSequence;II)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
