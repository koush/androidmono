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
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void onPressed()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, "onPressed", "()V", ref global::android.inputmethodservice.Keyboard.Key._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual void onReleased(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, "onReleased", "(Z)V", ref global::android.inputmethodservice.Keyboard.Key._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual bool isInside(int arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, "isInside", "(II)Z", ref global::android.inputmethodservice.Keyboard.Key._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual int squaredDistanceFrom(int arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, "squaredDistanceFrom", "(II)I", ref global::android.inputmethodservice.Keyboard.Key._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new int[] CurrentDrawableState
			{
				get
				{
					return getCurrentDrawableState();
				}
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual int[] getCurrentDrawableState()
			{
				return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.inputmethodservice.Keyboard.Key.staticClass, "getCurrentDrawableState", "()[I", ref global::android.inputmethodservice.Keyboard.Key._m4) as int[];
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public Key(android.inputmethodservice.Keyboard.Row arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.inputmethodservice.Keyboard.Key._m5.native == global::System.IntPtr.Zero)
					global::android.inputmethodservice.Keyboard.Key._m5 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "<init>", "(Landroid/inputmethodservice/Keyboard$Row;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public Key(android.content.res.Resources arg0, android.inputmethodservice.Keyboard.Row arg1, int arg2, int arg3, android.content.res.XmlResourceParser arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.inputmethodservice.Keyboard.Key._m6.native == global::System.IntPtr.Zero)
					global::android.inputmethodservice.Keyboard.Key._m6 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandroid/content/res/XmlResourceParser;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _codes2563;
			public int[] codes
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetObjectField(this.JvmHandle, _codes2563)) as int[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _label2564;
			public global::java.lang.CharSequence label
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _label2564)) as java.lang.CharSequence;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _icon2565;
			public global::android.graphics.drawable.Drawable icon
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _icon2565)) as android.graphics.drawable.Drawable;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _iconPreview2566;
			public global::android.graphics.drawable.Drawable iconPreview
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _iconPreview2566)) as android.graphics.drawable.Drawable;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _width2567;
			public int width
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _width2567);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _height2568;
			public int height
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _height2568);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _gap2569;
			public int gap
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _gap2569);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _sticky2570;
			public bool sticky
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _sticky2570);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _x2571;
			public int x
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _x2571);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _y2572;
			public int y
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _y2572);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _pressed2573;
			public bool pressed
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _pressed2573);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _on2574;
			public bool on
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _on2574);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _text2575;
			public global::java.lang.CharSequence text
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _text2575)) as java.lang.CharSequence;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _popupCharacters2576;
			public global::java.lang.CharSequence popupCharacters
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _popupCharacters2576)) as java.lang.CharSequence;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _edgeFlags2577;
			public int edgeFlags
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _edgeFlags2577);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _modifier2578;
			public bool modifier
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _modifier2578);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _popupResId2579;
			public int popupResId
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _popupResId2579);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _repeatable2580;
			public bool repeatable
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _repeatable2580);
				}
				set
				{
				}
			}
			static Key()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.Keyboard.Key.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/Keyboard$Key"));
				global::android.inputmethodservice.Keyboard.Key._codes2563 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "codes", "[I");
				global::android.inputmethodservice.Keyboard.Key._label2564 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "label", "Ljava/lang/CharSequence;");
				global::android.inputmethodservice.Keyboard.Key._icon2565 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "icon", "Landroid/graphics/drawable/Drawable;");
				global::android.inputmethodservice.Keyboard.Key._iconPreview2566 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "iconPreview", "Landroid/graphics/drawable/Drawable;");
				global::android.inputmethodservice.Keyboard.Key._width2567 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "width", "I");
				global::android.inputmethodservice.Keyboard.Key._height2568 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "height", "I");
				global::android.inputmethodservice.Keyboard.Key._gap2569 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "gap", "I");
				global::android.inputmethodservice.Keyboard.Key._sticky2570 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "sticky", "Z");
				global::android.inputmethodservice.Keyboard.Key._x2571 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "x", "I");
				global::android.inputmethodservice.Keyboard.Key._y2572 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "y", "I");
				global::android.inputmethodservice.Keyboard.Key._pressed2573 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "pressed", "Z");
				global::android.inputmethodservice.Keyboard.Key._on2574 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "on", "Z");
				global::android.inputmethodservice.Keyboard.Key._text2575 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "text", "Ljava/lang/CharSequence;");
				global::android.inputmethodservice.Keyboard.Key._popupCharacters2576 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "popupCharacters", "Ljava/lang/CharSequence;");
				global::android.inputmethodservice.Keyboard.Key._edgeFlags2577 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "edgeFlags", "I");
				global::android.inputmethodservice.Keyboard.Key._modifier2578 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "modifier", "Z");
				global::android.inputmethodservice.Keyboard.Key._popupResId2579 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "popupResId", "I");
				global::android.inputmethodservice.Keyboard.Key._repeatable2580 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "repeatable", "Z");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Row : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Row(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public Row(android.inputmethodservice.Keyboard arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.inputmethodservice.Keyboard.Row._m0.native == global::System.IntPtr.Zero)
					global::android.inputmethodservice.Keyboard.Row._m0 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "<init>", "(Landroid/inputmethodservice/Keyboard;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Row.staticClass, global::android.inputmethodservice.Keyboard.Row._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public Row(android.content.res.Resources arg0, android.inputmethodservice.Keyboard arg1, android.content.res.XmlResourceParser arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.inputmethodservice.Keyboard.Row._m1.native == global::System.IntPtr.Zero)
					global::android.inputmethodservice.Keyboard.Row._m1 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard;Landroid/content/res/XmlResourceParser;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Row.staticClass, global::android.inputmethodservice.Keyboard.Row._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _defaultWidth2581;
			public int defaultWidth
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _defaultWidth2581);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _defaultHeight2582;
			public int defaultHeight
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _defaultHeight2582);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _defaultHorizontalGap2583;
			public int defaultHorizontalGap
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _defaultHorizontalGap2583);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _verticalGap2584;
			public int verticalGap
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _verticalGap2584);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _rowEdgeFlags2585;
			public int rowEdgeFlags
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _rowEdgeFlags2585);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _mode2586;
			public int mode
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _mode2586);
				}
				set
				{
				}
			}
			static Row()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.Keyboard.Row.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/Keyboard$Row"));
				global::android.inputmethodservice.Keyboard.Row._defaultWidth2581 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "defaultWidth", "I");
				global::android.inputmethodservice.Keyboard.Row._defaultHeight2582 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "defaultHeight", "I");
				global::android.inputmethodservice.Keyboard.Row._defaultHorizontalGap2583 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "defaultHorizontalGap", "I");
				global::android.inputmethodservice.Keyboard.Row._verticalGap2584 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "verticalGap", "I");
				global::android.inputmethodservice.Keyboard.Row._rowEdgeFlags2585 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "rowEdgeFlags", "I");
				global::android.inputmethodservice.Keyboard.Row._mode2586 = @__env.GetFieldIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "mode", "I");
			}
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, "getHeight", "()I", ref global::android.inputmethodservice.Keyboard._m0);
		}
		public new global::java.util.List Keys
		{
			get
			{
				return getKeys();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.util.List getKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.inputmethodservice.Keyboard.staticClass, "getKeys", "()Ljava/util/List;", ref global::android.inputmethodservice.Keyboard._m1) as java.util.List;
		}
		public new global::java.util.List ModifierKeys
		{
			get
			{
				return getModifierKeys();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.util.List getModifierKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.inputmethodservice.Keyboard.staticClass, "getModifierKeys", "()Ljava/util/List;", ref global::android.inputmethodservice.Keyboard._m2) as java.util.List;
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
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual int getHorizontalGap()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, "getHorizontalGap", "()I", ref global::android.inputmethodservice.Keyboard._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual void setHorizontalGap(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, "setHorizontalGap", "(I)V", ref global::android.inputmethodservice.Keyboard._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual int getVerticalGap()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, "getVerticalGap", "()I", ref global::android.inputmethodservice.Keyboard._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected virtual void setVerticalGap(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, "setVerticalGap", "(I)V", ref global::android.inputmethodservice.Keyboard._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual int getKeyHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, "getKeyHeight", "()I", ref global::android.inputmethodservice.Keyboard._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual void setKeyHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, "setKeyHeight", "(I)V", ref global::android.inputmethodservice.Keyboard._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual int getKeyWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, "getKeyWidth", "()I", ref global::android.inputmethodservice.Keyboard._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual void setKeyWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, "setKeyWidth", "(I)V", ref global::android.inputmethodservice.Keyboard._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinWidth
		{
			get
			{
				return getMinWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getMinWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, "getMinWidth", "()I", ref global::android.inputmethodservice.Keyboard._m11);
		}
		public new bool Shifted
		{
			set
			{
				setShifted(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool setShifted(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.Keyboard.staticClass, "setShifted", "(Z)Z", ref global::android.inputmethodservice.Keyboard._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool isShifted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.Keyboard.staticClass, "isShifted", "()Z", ref global::android.inputmethodservice.Keyboard._m13);
		}
		public new int ShiftKeyIndex
		{
			get
			{
				return getShiftKeyIndex();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int getShiftKeyIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, "getShiftKeyIndex", "()I", ref global::android.inputmethodservice.Keyboard._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int[] getNearestKeys(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.inputmethodservice.Keyboard.staticClass, "getNearestKeys", "(II)[I", ref global::android.inputmethodservice.Keyboard._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected virtual global::android.inputmethodservice.Keyboard.Row createRowFromXml(android.content.res.Resources arg0, android.content.res.XmlResourceParser arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.Keyboard.staticClass, "createRowFromXml", "(Landroid/content/res/Resources;Landroid/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Row;", ref global::android.inputmethodservice.Keyboard._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.inputmethodservice.Keyboard.Row;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected virtual global::android.inputmethodservice.Keyboard.Key createKeyFromXml(android.content.res.Resources arg0, android.inputmethodservice.Keyboard.Row arg1, int arg2, int arg3, android.content.res.XmlResourceParser arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.inputmethodservice.Keyboard.staticClass, "createKeyFromXml", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandroid/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Key;", ref global::android.inputmethodservice.Keyboard._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.inputmethodservice.Keyboard.Key;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public Keyboard(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.Keyboard._m18.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.Keyboard._m18 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public Keyboard(android.content.Context arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.Keyboard._m19.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.Keyboard._m19 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public Keyboard(android.content.Context arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.Keyboard._m20.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.Keyboard._m20 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;ILjava/lang/CharSequence;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
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
		}
	}
}
