namespace android.inputmethodservice
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Keyboard : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Keyboard()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.inputmethodservice.Keyboard), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.inputmethodservice.Keyboard(@__env);
			}
		}
		protected Keyboard(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Key : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Key()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.inputmethodservice.Keyboard.Key), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.inputmethodservice.Keyboard.Key(@__env);
				}
			}
			protected Key(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onPressed4335;
			public virtual void onPressed() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.Key._onPressed4335);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._onPressed4335);
			}
			internal static global::net.sf.jni4net.jni.MethodId _onReleased4336;
			public virtual void onReleased(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.Key._onReleased4336, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._onReleased4336, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _isInside4337;
			public virtual bool isInside(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.inputmethodservice.Keyboard.Key._isInside4337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._isInside4337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _squaredDistanceFrom4338;
			public virtual int squaredDistanceFrom(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard.Key._squaredDistanceFrom4338, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._squaredDistanceFrom4338, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getCurrentDrawableState4339;
			public virtual int[] getCurrentDrawableState() 
			{
				if (!IsClrObject)
					return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.Keyboard.Key._getCurrentDrawableState4339));
				else
					return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._getCurrentDrawableState4339));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Key4340;
			public Key(android.inputmethodservice.Keyboard.Row arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._Key4340, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Key4341;
			public Key(android.content.res.Resources arg0, android.inputmethodservice.Keyboard.Row arg1, int arg2, int arg3, android.content.res.XmlResourceParser arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._Key4341, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4));
			}
			internal static global::net.sf.jni4net.jni.FieldId _codes4342;
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
			internal static global::net.sf.jni4net.jni.FieldId _label4343;
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
			internal static global::net.sf.jni4net.jni.FieldId _icon4344;
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
			internal static global::net.sf.jni4net.jni.FieldId _iconPreview4345;
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
			internal static global::net.sf.jni4net.jni.FieldId _width4346;
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
			internal static global::net.sf.jni4net.jni.FieldId _height4347;
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
			internal static global::net.sf.jni4net.jni.FieldId _gap4348;
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
			internal static global::net.sf.jni4net.jni.FieldId _sticky4349;
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
			internal static global::net.sf.jni4net.jni.FieldId _x4350;
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
			internal static global::net.sf.jni4net.jni.FieldId _y4351;
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
			internal static global::net.sf.jni4net.jni.FieldId _pressed4352;
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
			internal static global::net.sf.jni4net.jni.FieldId _on4353;
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
			internal static global::net.sf.jni4net.jni.FieldId _text4354;
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
			internal static global::net.sf.jni4net.jni.FieldId _popupCharacters4355;
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
			internal static global::net.sf.jni4net.jni.FieldId _edgeFlags4356;
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
			internal static global::net.sf.jni4net.jni.FieldId _modifier4357;
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
			internal static global::net.sf.jni4net.jni.FieldId _popupResId4358;
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
			internal static global::net.sf.jni4net.jni.FieldId _repeatable4359;
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.inputmethodservice.Keyboard.Key.staticClass = @__class;
				global::android.inputmethodservice.Keyboard.Key._onPressed4335 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "onPressed", "()V");
				global::android.inputmethodservice.Keyboard.Key._onReleased4336 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "onReleased", "(Z)V");
				global::android.inputmethodservice.Keyboard.Key._isInside4337 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "isInside", "(II)Z");
				global::android.inputmethodservice.Keyboard.Key._squaredDistanceFrom4338 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "squaredDistanceFrom", "(II)I");
				global::android.inputmethodservice.Keyboard.Key._getCurrentDrawableState4339 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "getCurrentDrawableState", "()[I");
				global::android.inputmethodservice.Keyboard.Key._Key4340 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "<init>", "(Landroid/inputmethodservice/Keyboard$Row;)V");
				global::android.inputmethodservice.Keyboard.Key._Key4341 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandroid/content/res/XmlResourceParser;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Row : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Row()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.inputmethodservice.Keyboard.Row), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.inputmethodservice.Keyboard.Row(@__env);
				}
			}
			protected Row(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _Row4360;
			public Row(android.inputmethodservice.Keyboard arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.inputmethodservice.Keyboard.Row.staticClass, global::android.inputmethodservice.Keyboard.Row._Row4360, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Row4361;
			public Row(android.content.res.Resources arg0, android.inputmethodservice.Keyboard arg1, android.content.res.XmlResourceParser arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.inputmethodservice.Keyboard.Row.staticClass, global::android.inputmethodservice.Keyboard.Row._Row4361, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			}
			internal static global::net.sf.jni4net.jni.FieldId _defaultWidth4362;
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
			internal static global::net.sf.jni4net.jni.FieldId _defaultHeight4363;
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
			internal static global::net.sf.jni4net.jni.FieldId _defaultHorizontalGap4364;
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
			internal static global::net.sf.jni4net.jni.FieldId _verticalGap4365;
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
			internal static global::net.sf.jni4net.jni.FieldId _rowEdgeFlags4366;
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
			internal static global::net.sf.jni4net.jni.FieldId _mode4367;
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.inputmethodservice.Keyboard.Row.staticClass = @__class;
				global::android.inputmethodservice.Keyboard.Row._Row4360 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Row.staticClass, "<init>", "(Landroid/inputmethodservice/Keyboard;)V");
				global::android.inputmethodservice.Keyboard.Row._Row4361 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Row.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard;Landroid/content/res/XmlResourceParser;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeight4368;
		public virtual int getHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard._getHeight4368);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getHeight4368);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKeys4369;
		public virtual global::java.util.List getKeys() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.Keyboard._getKeys4369));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getKeys4369));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getModifierKeys4370;
		public virtual global::java.util.List getModifierKeys() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.Keyboard._getModifierKeys4370));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getModifierKeys4370));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHorizontalGap4371;
		protected virtual int getHorizontalGap() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard._getHorizontalGap4371);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getHorizontalGap4371);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalGap4372;
		protected virtual void setHorizontalGap(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.Keyboard._setHorizontalGap4372, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setHorizontalGap4372, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVerticalGap4373;
		protected virtual int getVerticalGap() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard._getVerticalGap4373);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getVerticalGap4373);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalGap4374;
		protected virtual void setVerticalGap(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.Keyboard._setVerticalGap4374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setVerticalGap4374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKeyHeight4375;
		protected virtual int getKeyHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard._getKeyHeight4375);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getKeyHeight4375);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setKeyHeight4376;
		protected virtual void setKeyHeight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.Keyboard._setKeyHeight4376, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setKeyHeight4376, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKeyWidth4377;
		protected virtual int getKeyWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard._getKeyWidth4377);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getKeyWidth4377);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setKeyWidth4378;
		protected virtual void setKeyWidth(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.Keyboard._setKeyWidth4378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setKeyWidth4378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinWidth4379;
		public virtual int getMinWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard._getMinWidth4379);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getMinWidth4379);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setShifted4380;
		public virtual bool setShifted(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.Keyboard._setShifted4380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setShifted4380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isShifted4381;
		public virtual bool isShifted() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.Keyboard._isShifted4381);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._isShifted4381);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShiftKeyIndex4382;
		public virtual int getShiftKeyIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard._getShiftKeyIndex4382);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getShiftKeyIndex4382);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNearestKeys4383;
		public virtual int[] getNearestKeys(int arg0, int arg1) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.Keyboard._getNearestKeys4383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getNearestKeys4383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createRowFromXml4384;
		protected virtual global::android.inputmethodservice.Keyboard.Row createRowFromXml(android.content.res.Resources arg0, android.content.res.XmlResourceParser arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard.Row>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.Keyboard._createRowFromXml4384, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard.Row>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._createRowFromXml4384, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createKeyFromXml4385;
		protected virtual global::android.inputmethodservice.Keyboard.Key createKeyFromXml(android.content.res.Resources arg0, android.inputmethodservice.Keyboard.Row arg1, int arg2, int arg3, android.content.res.XmlResourceParser arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard.Key>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.Keyboard._createKeyFromXml4385, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard.Key>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._createKeyFromXml4385, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Keyboard4386;
		public Keyboard(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._Keyboard4386, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Keyboard4387;
		public Keyboard(android.content.Context arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._Keyboard4387, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Keyboard4388;
		public Keyboard(android.content.Context arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._Keyboard4388, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.inputmethodservice.Keyboard.staticClass = @__class;
			global::android.inputmethodservice.Keyboard._getHeight4368 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getHeight", "()I");
			global::android.inputmethodservice.Keyboard._getKeys4369 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getKeys", "()Ljava/util/List;");
			global::android.inputmethodservice.Keyboard._getModifierKeys4370 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getModifierKeys", "()Ljava/util/List;");
			global::android.inputmethodservice.Keyboard._getHorizontalGap4371 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getHorizontalGap", "()I");
			global::android.inputmethodservice.Keyboard._setHorizontalGap4372 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "setHorizontalGap", "(I)V");
			global::android.inputmethodservice.Keyboard._getVerticalGap4373 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getVerticalGap", "()I");
			global::android.inputmethodservice.Keyboard._setVerticalGap4374 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "setVerticalGap", "(I)V");
			global::android.inputmethodservice.Keyboard._getKeyHeight4375 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getKeyHeight", "()I");
			global::android.inputmethodservice.Keyboard._setKeyHeight4376 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "setKeyHeight", "(I)V");
			global::android.inputmethodservice.Keyboard._getKeyWidth4377 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getKeyWidth", "()I");
			global::android.inputmethodservice.Keyboard._setKeyWidth4378 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "setKeyWidth", "(I)V");
			global::android.inputmethodservice.Keyboard._getMinWidth4379 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getMinWidth", "()I");
			global::android.inputmethodservice.Keyboard._setShifted4380 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "setShifted", "(Z)Z");
			global::android.inputmethodservice.Keyboard._isShifted4381 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "isShifted", "()Z");
			global::android.inputmethodservice.Keyboard._getShiftKeyIndex4382 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getShiftKeyIndex", "()I");
			global::android.inputmethodservice.Keyboard._getNearestKeys4383 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getNearestKeys", "(II)[I");
			global::android.inputmethodservice.Keyboard._createRowFromXml4384 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "createRowFromXml", "(Landroid/content/res/Resources;Landroid/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Row;");
			global::android.inputmethodservice.Keyboard._createKeyFromXml4385 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "createKeyFromXml", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandroid/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Key;");
			global::android.inputmethodservice.Keyboard._Keyboard4386 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.inputmethodservice.Keyboard._Keyboard4387 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::android.inputmethodservice.Keyboard._Keyboard4388 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;ILjava/lang/CharSequence;II)V");
		}
	}
}
