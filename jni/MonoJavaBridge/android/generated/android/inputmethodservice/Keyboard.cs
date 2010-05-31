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
			internal static global::net.sf.jni4net.jni.MethodId _onPressed4103;
			public virtual void onPressed() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.Key._onPressed4103);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._onPressed4103);
			}
			internal static global::net.sf.jni4net.jni.MethodId _onReleased4104;
			public virtual void onReleased(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.inputmethodservice.Keyboard.Key._onReleased4104, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._onReleased4104, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _isInside4105;
			public virtual bool isInside(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.inputmethodservice.Keyboard.Key._isInside4105, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._isInside4105, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _squaredDistanceFrom4106;
			public virtual int squaredDistanceFrom(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard.Key._squaredDistanceFrom4106, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._squaredDistanceFrom4106, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getCurrentDrawableState4107;
			public virtual int[] getCurrentDrawableState() 
			{
				if (!IsClrObject)
					return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.Keyboard.Key._getCurrentDrawableState4107));
				else
					return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._getCurrentDrawableState4107));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Key4108;
			public Key(android.inputmethodservice.Keyboard.Row arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._Key4108, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Key4109;
			public Key(android.content.res.Resources arg0, android.inputmethodservice.Keyboard.Row arg1, int arg2, int arg3, android.content.res.XmlResourceParser arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.inputmethodservice.Keyboard.Key.staticClass, global::android.inputmethodservice.Keyboard.Key._Key4109, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4));
			}
			internal static global::net.sf.jni4net.jni.FieldId _codes4110;
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
			internal static global::net.sf.jni4net.jni.FieldId _label4111;
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
			internal static global::net.sf.jni4net.jni.FieldId _icon4112;
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
			internal static global::net.sf.jni4net.jni.FieldId _iconPreview4113;
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
			internal static global::net.sf.jni4net.jni.FieldId _width4114;
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
			internal static global::net.sf.jni4net.jni.FieldId _height4115;
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
			internal static global::net.sf.jni4net.jni.FieldId _gap4116;
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
			internal static global::net.sf.jni4net.jni.FieldId _sticky4117;
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
			internal static global::net.sf.jni4net.jni.FieldId _x4118;
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
			internal static global::net.sf.jni4net.jni.FieldId _y4119;
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
			internal static global::net.sf.jni4net.jni.FieldId _pressed4120;
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
			internal static global::net.sf.jni4net.jni.FieldId _on4121;
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
			internal static global::net.sf.jni4net.jni.FieldId _text4122;
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
			internal static global::net.sf.jni4net.jni.FieldId _popupCharacters4123;
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
			internal static global::net.sf.jni4net.jni.FieldId _edgeFlags4124;
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
			internal static global::net.sf.jni4net.jni.FieldId _modifier4125;
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
			internal static global::net.sf.jni4net.jni.FieldId _popupResId4126;
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
			internal static global::net.sf.jni4net.jni.FieldId _repeatable4127;
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
				global::android.inputmethodservice.Keyboard.Key._onPressed4103 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "onPressed", "()V");
				global::android.inputmethodservice.Keyboard.Key._onReleased4104 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "onReleased", "(Z)V");
				global::android.inputmethodservice.Keyboard.Key._isInside4105 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "isInside", "(II)Z");
				global::android.inputmethodservice.Keyboard.Key._squaredDistanceFrom4106 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "squaredDistanceFrom", "(II)I");
				global::android.inputmethodservice.Keyboard.Key._getCurrentDrawableState4107 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "getCurrentDrawableState", "()[I");
				global::android.inputmethodservice.Keyboard.Key._Key4108 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "<init>", "(Landroid/inputmethodservice/Keyboard$Row;)V");
				global::android.inputmethodservice.Keyboard.Key._Key4109 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandroid/content/res/XmlResourceParser;)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _Row4128;
			public Row(android.inputmethodservice.Keyboard arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.inputmethodservice.Keyboard.Row.staticClass, global::android.inputmethodservice.Keyboard.Row._Row4128, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Row4129;
			public Row(android.content.res.Resources arg0, android.inputmethodservice.Keyboard arg1, android.content.res.XmlResourceParser arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.inputmethodservice.Keyboard.Row.staticClass, global::android.inputmethodservice.Keyboard.Row._Row4129, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			}
			internal static global::net.sf.jni4net.jni.FieldId _defaultWidth4130;
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
			internal static global::net.sf.jni4net.jni.FieldId _defaultHeight4131;
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
			internal static global::net.sf.jni4net.jni.FieldId _defaultHorizontalGap4132;
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
			internal static global::net.sf.jni4net.jni.FieldId _verticalGap4133;
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
			internal static global::net.sf.jni4net.jni.FieldId _rowEdgeFlags4134;
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
			internal static global::net.sf.jni4net.jni.FieldId _mode4135;
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
				global::android.inputmethodservice.Keyboard.Row._Row4128 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Row.staticClass, "<init>", "(Landroid/inputmethodservice/Keyboard;)V");
				global::android.inputmethodservice.Keyboard.Row._Row4129 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Row.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard;Landroid/content/res/XmlResourceParser;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeight4136;
		public virtual int getHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard._getHeight4136);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getHeight4136);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKeys4137;
		public virtual global::java.util.List getKeys() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.Keyboard._getKeys4137));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getKeys4137));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getModifierKeys4138;
		public virtual global::java.util.List getModifierKeys() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.Keyboard._getModifierKeys4138));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getModifierKeys4138));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHorizontalGap4139;
		protected virtual int getHorizontalGap() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard._getHorizontalGap4139);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getHorizontalGap4139);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalGap4140;
		protected virtual void setHorizontalGap(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.Keyboard._setHorizontalGap4140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setHorizontalGap4140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVerticalGap4141;
		protected virtual int getVerticalGap() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard._getVerticalGap4141);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getVerticalGap4141);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalGap4142;
		protected virtual void setVerticalGap(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.Keyboard._setVerticalGap4142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setVerticalGap4142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKeyHeight4143;
		protected virtual int getKeyHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard._getKeyHeight4143);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getKeyHeight4143);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setKeyHeight4144;
		protected virtual void setKeyHeight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.Keyboard._setKeyHeight4144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setKeyHeight4144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKeyWidth4145;
		protected virtual int getKeyWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard._getKeyWidth4145);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getKeyWidth4145);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setKeyWidth4146;
		protected virtual void setKeyWidth(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.Keyboard._setKeyWidth4146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setKeyWidth4146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinWidth4147;
		public virtual int getMinWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard._getMinWidth4147);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getMinWidth4147);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setShifted4148;
		public virtual bool setShifted(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.Keyboard._setShifted4148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._setShifted4148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isShifted4149;
		public virtual bool isShifted() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.Keyboard._isShifted4149);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._isShifted4149);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShiftKeyIndex4150;
		public virtual int getShiftKeyIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.inputmethodservice.Keyboard._getShiftKeyIndex4150);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getShiftKeyIndex4150);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNearestKeys4151;
		public virtual int[] getNearestKeys(int arg0, int arg1) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.Keyboard._getNearestKeys4151, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._getNearestKeys4151, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createRowFromXml4152;
		protected virtual global::android.inputmethodservice.Keyboard.Row createRowFromXml(android.content.res.Resources arg0, android.content.res.XmlResourceParser arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard.Row>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.Keyboard._createRowFromXml4152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard.Row>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._createRowFromXml4152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createKeyFromXml4153;
		protected virtual global::android.inputmethodservice.Keyboard.Key createKeyFromXml(android.content.res.Resources arg0, android.inputmethodservice.Keyboard.Row arg1, int arg2, int arg3, android.content.res.XmlResourceParser arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard.Key>(@__env, @__env.CallObjectMethodPtr(this, global::android.inputmethodservice.Keyboard._createKeyFromXml4153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard.Key>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._createKeyFromXml4153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Keyboard4154;
		public Keyboard(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._Keyboard4154, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Keyboard4155;
		public Keyboard(android.content.Context arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._Keyboard4155, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Keyboard4156;
		public Keyboard(android.content.Context arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.inputmethodservice.Keyboard.staticClass, global::android.inputmethodservice.Keyboard._Keyboard4156, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
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
			global::android.inputmethodservice.Keyboard._getHeight4136 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getHeight", "()I");
			global::android.inputmethodservice.Keyboard._getKeys4137 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getKeys", "()Ljava/util/List;");
			global::android.inputmethodservice.Keyboard._getModifierKeys4138 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getModifierKeys", "()Ljava/util/List;");
			global::android.inputmethodservice.Keyboard._getHorizontalGap4139 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getHorizontalGap", "()I");
			global::android.inputmethodservice.Keyboard._setHorizontalGap4140 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "setHorizontalGap", "(I)V");
			global::android.inputmethodservice.Keyboard._getVerticalGap4141 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getVerticalGap", "()I");
			global::android.inputmethodservice.Keyboard._setVerticalGap4142 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "setVerticalGap", "(I)V");
			global::android.inputmethodservice.Keyboard._getKeyHeight4143 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getKeyHeight", "()I");
			global::android.inputmethodservice.Keyboard._setKeyHeight4144 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "setKeyHeight", "(I)V");
			global::android.inputmethodservice.Keyboard._getKeyWidth4145 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getKeyWidth", "()I");
			global::android.inputmethodservice.Keyboard._setKeyWidth4146 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "setKeyWidth", "(I)V");
			global::android.inputmethodservice.Keyboard._getMinWidth4147 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getMinWidth", "()I");
			global::android.inputmethodservice.Keyboard._setShifted4148 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "setShifted", "(Z)Z");
			global::android.inputmethodservice.Keyboard._isShifted4149 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "isShifted", "()Z");
			global::android.inputmethodservice.Keyboard._getShiftKeyIndex4150 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getShiftKeyIndex", "()I");
			global::android.inputmethodservice.Keyboard._getNearestKeys4151 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getNearestKeys", "(II)[I");
			global::android.inputmethodservice.Keyboard._createRowFromXml4152 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "createRowFromXml", "(Landroid/content/res/Resources;Landroid/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Row;");
			global::android.inputmethodservice.Keyboard._createKeyFromXml4153 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "createKeyFromXml", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandroid/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Key;");
			global::android.inputmethodservice.Keyboard._Keyboard4154 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.inputmethodservice.Keyboard._Keyboard4155 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::android.inputmethodservice.Keyboard._Keyboard4156 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;ILjava/lang/CharSequence;II)V");
		}
	}
}
