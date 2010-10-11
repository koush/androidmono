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
			internal static global::MonoJavaBridge.MethodId _onPressed4557;
			public virtual void onPressed() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key._onPressed4557);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._onPressed4557);
			}
			internal static global::MonoJavaBridge.MethodId _onReleased4558;
			public virtual void onReleased(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key._onReleased4558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._onReleased4558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isInside4559;
			public virtual bool isInside(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key._isInside4559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._isInside4559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _squaredDistanceFrom4560;
			public virtual int squaredDistanceFrom(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key._squaredDistanceFrom4560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._squaredDistanceFrom4560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _getCurrentDrawableState4561;
			public virtual int[] getCurrentDrawableState() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key._getCurrentDrawableState4561)) as int[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._getCurrentDrawableState4561)) as int[];
			}
			internal static global::MonoJavaBridge.MethodId _Key4562;
			public Key(android.inputmethodservice.Keyboard.Row arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._Key4562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _Key4563;
			public Key(android.content.res.Resources arg0, android.inputmethodservice.Keyboard.Row arg1, int arg2, int arg3, android.content.res.XmlResourceParser arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._Key4563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _codes4564;
			public int[] codes
			{
				get
				{
					return default(int[]);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _label4565;
			public global::java.lang.CharSequence label
			{
				get
				{
					return default(global::java.lang.CharSequence);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _icon4566;
			public global::android.graphics.drawable.Drawable icon
			{
				get
				{
					return default(global::android.graphics.drawable.Drawable);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _iconPreview4567;
			public global::android.graphics.drawable.Drawable iconPreview
			{
				get
				{
					return default(global::android.graphics.drawable.Drawable);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _width4568;
			public int width
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _height4569;
			public int height
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _gap4570;
			public int gap
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _sticky4571;
			public bool sticky
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _x4572;
			public int x
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _y4573;
			public int y
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _pressed4574;
			public bool pressed
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _on4575;
			public bool on
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _text4576;
			public global::java.lang.CharSequence text
			{
				get
				{
					return default(global::java.lang.CharSequence);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _popupCharacters4577;
			public global::java.lang.CharSequence popupCharacters
			{
				get
				{
					return default(global::java.lang.CharSequence);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _edgeFlags4578;
			public int edgeFlags
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _modifier4579;
			public bool modifier
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _popupResId4580;
			public int popupResId
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _repeatable4581;
			public bool repeatable
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.Keyboard.Key.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/Keyboard$Key"));
				global::android.inputmethodservice.Keyboard.Key._onPressed4557 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "onPressed", "()V");
				global::android.inputmethodservice.Keyboard.Key._onReleased4558 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "onReleased", "(Z)V");
				global::android.inputmethodservice.Keyboard.Key._isInside4559 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "isInside", "(II)Z");
				global::android.inputmethodservice.Keyboard.Key._squaredDistanceFrom4560 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "squaredDistanceFrom", "(II)I");
				global::android.inputmethodservice.Keyboard.Key._getCurrentDrawableState4561 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "getCurrentDrawableState", "()[I");
				global::android.inputmethodservice.Keyboard.Key._Key4562 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "<init>", "(Landroid/inputmethodservice/Keyboard$Row;)V");
				global::android.inputmethodservice.Keyboard.Key._Key4563 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Key.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandroid/content/res/XmlResourceParser;)V");
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
			internal static global::MonoJavaBridge.MethodId _Row4582;
			public Row(android.inputmethodservice.Keyboard arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Row.staticClass, global::android.inputmethodservice.Keyboard.Row._Row4582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _Row4583;
			public Row(android.content.res.Resources arg0, android.inputmethodservice.Keyboard arg1, android.content.res.XmlResourceParser arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.Row.staticClass, global::android.inputmethodservice.Keyboard.Row._Row4583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _defaultWidth4584;
			public int defaultWidth
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _defaultHeight4585;
			public int defaultHeight
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _defaultHorizontalGap4586;
			public int defaultHorizontalGap
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _verticalGap4587;
			public int verticalGap
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _rowEdgeFlags4588;
			public int rowEdgeFlags
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _mode4589;
			public int mode
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.inputmethodservice.Keyboard.Row.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/Keyboard$Row"));
				global::android.inputmethodservice.Keyboard.Row._Row4582 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "<init>", "(Landroid/inputmethodservice/Keyboard;)V");
				global::android.inputmethodservice.Keyboard.Row._Row4583 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.Row.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard;Landroid/content/res/XmlResourceParser;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight4590;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getHeight4590);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getHeight4590);
		}
		internal static global::MonoJavaBridge.MethodId _getKeys4591;
		public virtual global::java.util.List getKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getKeys4591)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getKeys4591)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getModifierKeys4592;
		public virtual global::java.util.List getModifierKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getModifierKeys4592)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getModifierKeys4592)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalGap4593;
		protected virtual int getHorizontalGap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getHorizontalGap4593);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getHorizontalGap4593);
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalGap4594;
		protected virtual void setHorizontalGap(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._setHorizontalGap4594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setHorizontalGap4594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVerticalGap4595;
		protected virtual int getVerticalGap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getVerticalGap4595);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getVerticalGap4595);
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalGap4596;
		protected virtual void setVerticalGap(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._setVerticalGap4596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setVerticalGap4596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeyHeight4597;
		protected virtual int getKeyHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getKeyHeight4597);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getKeyHeight4597);
		}
		internal static global::MonoJavaBridge.MethodId _setKeyHeight4598;
		protected virtual void setKeyHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._setKeyHeight4598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setKeyHeight4598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getKeyWidth4599;
		protected virtual int getKeyWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getKeyWidth4599);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getKeyWidth4599);
		}
		internal static global::MonoJavaBridge.MethodId _setKeyWidth4600;
		protected virtual void setKeyWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._setKeyWidth4600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setKeyWidth4600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMinWidth4601;
		public virtual int getMinWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getMinWidth4601);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getMinWidth4601);
		}
		internal static global::MonoJavaBridge.MethodId _setShifted4602;
		public virtual bool setShifted(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._setShifted4602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setShifted4602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isShifted4603;
		public virtual bool isShifted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._isShifted4603);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._isShifted4603);
		}
		internal static global::MonoJavaBridge.MethodId _getShiftKeyIndex4604;
		public virtual int getShiftKeyIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getShiftKeyIndex4604);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getShiftKeyIndex4604);
		}
		internal static global::MonoJavaBridge.MethodId _getNearestKeys4605;
		public virtual int[] getNearestKeys(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._getNearestKeys4605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getNearestKeys4605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _createRowFromXml4606;
		protected virtual global::android.inputmethodservice.Keyboard.Row createRowFromXml(android.content.res.Resources arg0, android.content.res.XmlResourceParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._createRowFromXml4606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.inputmethodservice.Keyboard.Row;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._createRowFromXml4606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.inputmethodservice.Keyboard.Row;
		}
		internal static global::MonoJavaBridge.MethodId _createKeyFromXml4607;
		protected virtual global::android.inputmethodservice.Keyboard.Key createKeyFromXml(android.content.res.Resources arg0, android.inputmethodservice.Keyboard.Row arg1, int arg2, int arg3, android.content.res.XmlResourceParser arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard._createKeyFromXml4607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.inputmethodservice.Keyboard.Key;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._createKeyFromXml4607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.inputmethodservice.Keyboard.Key;
		}
		internal static global::MonoJavaBridge.MethodId _Keyboard4608;
		public Keyboard(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._Keyboard4608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Keyboard4609;
		public Keyboard(android.content.Context arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._Keyboard4609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Keyboard4610;
		public Keyboard(android.content.Context arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._Keyboard4610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
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
			global::android.inputmethodservice.Keyboard._getHeight4590 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getHeight", "()I");
			global::android.inputmethodservice.Keyboard._getKeys4591 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getKeys", "()Ljava/util/List;");
			global::android.inputmethodservice.Keyboard._getModifierKeys4592 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getModifierKeys", "()Ljava/util/List;");
			global::android.inputmethodservice.Keyboard._getHorizontalGap4593 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getHorizontalGap", "()I");
			global::android.inputmethodservice.Keyboard._setHorizontalGap4594 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "setHorizontalGap", "(I)V");
			global::android.inputmethodservice.Keyboard._getVerticalGap4595 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getVerticalGap", "()I");
			global::android.inputmethodservice.Keyboard._setVerticalGap4596 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "setVerticalGap", "(I)V");
			global::android.inputmethodservice.Keyboard._getKeyHeight4597 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getKeyHeight", "()I");
			global::android.inputmethodservice.Keyboard._setKeyHeight4598 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "setKeyHeight", "(I)V");
			global::android.inputmethodservice.Keyboard._getKeyWidth4599 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getKeyWidth", "()I");
			global::android.inputmethodservice.Keyboard._setKeyWidth4600 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "setKeyWidth", "(I)V");
			global::android.inputmethodservice.Keyboard._getMinWidth4601 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getMinWidth", "()I");
			global::android.inputmethodservice.Keyboard._setShifted4602 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "setShifted", "(Z)Z");
			global::android.inputmethodservice.Keyboard._isShifted4603 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "isShifted", "()Z");
			global::android.inputmethodservice.Keyboard._getShiftKeyIndex4604 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getShiftKeyIndex", "()I");
			global::android.inputmethodservice.Keyboard._getNearestKeys4605 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "getNearestKeys", "(II)[I");
			global::android.inputmethodservice.Keyboard._createRowFromXml4606 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "createRowFromXml", "(Landroid/content/res/Resources;Landroid/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Row;");
			global::android.inputmethodservice.Keyboard._createKeyFromXml4607 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "createKeyFromXml", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandroid/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Key;");
			global::android.inputmethodservice.Keyboard._Keyboard4608 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.inputmethodservice.Keyboard._Keyboard4609 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::android.inputmethodservice.Keyboard._Keyboard4610 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;ILjava/lang/CharSequence;II)V");
		}
	}
}
