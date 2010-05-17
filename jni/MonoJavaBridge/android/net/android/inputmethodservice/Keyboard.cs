namespace android.inputmethodservice 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Keyboard : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Keyboard() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.inputmethodservice.Keyboard), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.inputmethodservice.Keyboard.Key), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _onPressed3888; 
			public virtual void onPressed() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.Keyboard.Key)) 
					@__env.CallVoidMethod(this, _onPressed3888); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.Keyboard.Key.staticClass, _onPressed3888); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onReleased3889; 
			public virtual void onReleased(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.Keyboard.Key)) 
					@__env.CallVoidMethod(this, _onReleased3889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.Keyboard.Key.staticClass, _onReleased3889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isInside3890; 
			public virtual bool isInside(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.Keyboard.Key)) 
					return @__env.CallBooleanMethod(this, _isInside3890, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.Keyboard.Key.staticClass, _isInside3890, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _squaredDistanceFrom3891; 
			public virtual int squaredDistanceFrom(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.inputmethodservice.Keyboard.Key)) 
					return @__env.CallIntMethod(this, _squaredDistanceFrom3891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.inputmethodservice.Keyboard.Key.staticClass, _squaredDistanceFrom3891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getCurrentDrawableState3892; 
			public virtual int[] getCurrentDrawableState() 
			{ 
				if (GetType() == typeof(android.inputmethodservice.Keyboard.Key)) 
					return null;//(@__env, @__env.CallObjectMethodPtr(this, _getCurrentDrawableState3892)); 
				else 
					return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.Keyboard.Key.staticClass, _getCurrentDrawableState3892)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Key3893; 
			public Key(android.inputmethodservice.Keyboard.Row arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.inputmethodservice.Keyboard.Key.staticClass, _Key3893, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Key3894; 
			public Key(android.content.res.Resources arg0, android.inputmethodservice.Keyboard.Row arg1, int arg2, int arg3, android.content.res.XmlResourceParser arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.inputmethodservice.Keyboard.Key.staticClass, _Key3894, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _codes3895; 
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
			internal static global::net.sf.jni4net.jni.FieldId _label3896; 
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
			internal static global::net.sf.jni4net.jni.FieldId _icon3897; 
			public android.graphics.drawable.Drawable icon
			{ 
				get 
				{ 
					return default(android.graphics.drawable.Drawable); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _iconPreview3898; 
			public android.graphics.drawable.Drawable iconPreview
			{ 
				get 
				{ 
					return default(android.graphics.drawable.Drawable); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _width3899; 
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
			internal static global::net.sf.jni4net.jni.FieldId _height3900; 
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
			internal static global::net.sf.jni4net.jni.FieldId _gap3901; 
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
			internal static global::net.sf.jni4net.jni.FieldId _sticky3902; 
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
			internal static global::net.sf.jni4net.jni.FieldId _x3903; 
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
			internal static global::net.sf.jni4net.jni.FieldId _y3904; 
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
			internal static global::net.sf.jni4net.jni.FieldId _pressed3905; 
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
			internal static global::net.sf.jni4net.jni.FieldId _on3906; 
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
			internal static global::net.sf.jni4net.jni.FieldId _text3907; 
			public java.lang.CharSequence text
			{ 
				get 
				{ 
					return default(java.lang.CharSequence); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _popupCharacters3908; 
			public java.lang.CharSequence popupCharacters
			{ 
				get 
				{ 
					return default(java.lang.CharSequence); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _edgeFlags3909; 
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
			internal static global::net.sf.jni4net.jni.FieldId _modifier3910; 
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
			internal static global::net.sf.jni4net.jni.FieldId _popupResId3911; 
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
			internal static global::net.sf.jni4net.jni.FieldId _repeatable3912; 
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
				global::android.inputmethodservice.Keyboard.Key._onPressed3888 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "onPressed", "()V"); 
				global::android.inputmethodservice.Keyboard.Key._onReleased3889 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "onReleased", "(Z)V"); 
				global::android.inputmethodservice.Keyboard.Key._isInside3890 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "isInside", "(II)Z"); 
				global::android.inputmethodservice.Keyboard.Key._squaredDistanceFrom3891 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "squaredDistanceFrom", "(II)I"); 
				global::android.inputmethodservice.Keyboard.Key._getCurrentDrawableState3892 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "getCurrentDrawableState", "()[I"); 
				global::android.inputmethodservice.Keyboard.Key._Key3893 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "<init>", "(Landroid/inputmethodservice/Keyboard$Row;)V"); 
				global::android.inputmethodservice.Keyboard.Key._Key3894 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Key.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandroid/content/res/XmlResourceParser;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class Row : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Row() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.inputmethodservice.Keyboard.Row), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _Row3913; 
			public Row(android.inputmethodservice.Keyboard arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.inputmethodservice.Keyboard.Row.staticClass, _Row3913, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Row3914; 
			public Row(android.content.res.Resources arg0, android.inputmethodservice.Keyboard arg1, android.content.res.XmlResourceParser arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.inputmethodservice.Keyboard.Row.staticClass, _Row3914, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _defaultWidth3915; 
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
			internal static global::net.sf.jni4net.jni.FieldId _defaultHeight3916; 
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
			internal static global::net.sf.jni4net.jni.FieldId _defaultHorizontalGap3917; 
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
			internal static global::net.sf.jni4net.jni.FieldId _verticalGap3918; 
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
			internal static global::net.sf.jni4net.jni.FieldId _rowEdgeFlags3919; 
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
			internal static global::net.sf.jni4net.jni.FieldId _mode3920; 
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
				global::android.inputmethodservice.Keyboard.Row._Row3913 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Row.staticClass, "<init>", "(Landroid/inputmethodservice/Keyboard;)V"); 
				global::android.inputmethodservice.Keyboard.Row._Row3914 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.Row.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard;Landroid/content/res/XmlResourceParser;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight3921; 
		public virtual int getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				return @__env.CallIntMethod(this, _getHeight3921); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.inputmethodservice.Keyboard.staticClass, _getHeight3921); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeys3922; 
		public virtual java.util.List getKeys() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getKeys3922)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.Keyboard.staticClass, _getKeys3922)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getModifierKeys3923; 
		public virtual java.util.List getModifierKeys() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getModifierKeys3923)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.Keyboard.staticClass, _getModifierKeys3923)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHorizontalGap3924; 
		protected virtual int getHorizontalGap() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				return @__env.CallIntMethod(this, _getHorizontalGap3924); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.inputmethodservice.Keyboard.staticClass, _getHorizontalGap3924); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalGap3925; 
		protected virtual void setHorizontalGap(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				@__env.CallVoidMethod(this, _setHorizontalGap3925, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.Keyboard.staticClass, _setHorizontalGap3925, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVerticalGap3926; 
		protected virtual int getVerticalGap() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				return @__env.CallIntMethod(this, _getVerticalGap3926); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.inputmethodservice.Keyboard.staticClass, _getVerticalGap3926); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalGap3927; 
		protected virtual void setVerticalGap(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				@__env.CallVoidMethod(this, _setVerticalGap3927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.Keyboard.staticClass, _setVerticalGap3927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyHeight3928; 
		protected virtual int getKeyHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				return @__env.CallIntMethod(this, _getKeyHeight3928); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.inputmethodservice.Keyboard.staticClass, _getKeyHeight3928); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeyHeight3929; 
		protected virtual void setKeyHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				@__env.CallVoidMethod(this, _setKeyHeight3929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.Keyboard.staticClass, _setKeyHeight3929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyWidth3930; 
		protected virtual int getKeyWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				return @__env.CallIntMethod(this, _getKeyWidth3930); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.inputmethodservice.Keyboard.staticClass, _getKeyWidth3930); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeyWidth3931; 
		protected virtual void setKeyWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				@__env.CallVoidMethod(this, _setKeyWidth3931, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.Keyboard.staticClass, _setKeyWidth3931, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinWidth3932; 
		public virtual int getMinWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				return @__env.CallIntMethod(this, _getMinWidth3932); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.inputmethodservice.Keyboard.staticClass, _getMinWidth3932); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShifted3933; 
		public virtual bool setShifted(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				return @__env.CallBooleanMethod(this, _setShifted3933, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.Keyboard.staticClass, _setShifted3933, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShifted3934; 
		public virtual bool isShifted() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				return @__env.CallBooleanMethod(this, _isShifted3934); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.Keyboard.staticClass, _isShifted3934); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShiftKeyIndex3935; 
		public virtual int getShiftKeyIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				return @__env.CallIntMethod(this, _getShiftKeyIndex3935); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.inputmethodservice.Keyboard.staticClass, _getShiftKeyIndex3935); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNearestKeys3936; 
		public virtual int[] getNearestKeys(int arg0, int arg1) 
		{ 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getNearestKeys3936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.Keyboard.staticClass, _getNearestKeys3936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createRowFromXml3937; 
		protected virtual android.inputmethodservice.Keyboard.Row createRowFromXml(android.content.res.Resources arg0, android.content.res.XmlResourceParser arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard.Row>(@__env, @__env.CallObjectMethodPtr(this, _createRowFromXml3937, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard.Row>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.Keyboard.staticClass, _createRowFromXml3937, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createKeyFromXml3938; 
		protected virtual android.inputmethodservice.Keyboard.Key createKeyFromXml(android.content.res.Resources arg0, android.inputmethodservice.Keyboard.Row arg1, int arg2, int arg3, android.content.res.XmlResourceParser arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.Keyboard)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard.Key>(@__env, @__env.CallObjectMethodPtr(this, _createKeyFromXml3938, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.inputmethodservice.Keyboard.Key>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.inputmethodservice.Keyboard.staticClass, _createKeyFromXml3938, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Keyboard3939; 
		public Keyboard(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.Keyboard.staticClass, _Keyboard3939, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Keyboard3940; 
		public Keyboard(android.content.Context arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.Keyboard.staticClass, _Keyboard3940, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Keyboard3941; 
		public Keyboard(android.content.Context arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.Keyboard.staticClass, _Keyboard3941, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
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
			global::android.inputmethodservice.Keyboard._getHeight3921 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getHeight", "()I"); 
			global::android.inputmethodservice.Keyboard._getKeys3922 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getKeys", "()Ljava/util/List;"); 
			global::android.inputmethodservice.Keyboard._getModifierKeys3923 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getModifierKeys", "()Ljava/util/List;"); 
			global::android.inputmethodservice.Keyboard._getHorizontalGap3924 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getHorizontalGap", "()I"); 
			global::android.inputmethodservice.Keyboard._setHorizontalGap3925 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "setHorizontalGap", "(I)V"); 
			global::android.inputmethodservice.Keyboard._getVerticalGap3926 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getVerticalGap", "()I"); 
			global::android.inputmethodservice.Keyboard._setVerticalGap3927 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "setVerticalGap", "(I)V"); 
			global::android.inputmethodservice.Keyboard._getKeyHeight3928 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getKeyHeight", "()I"); 
			global::android.inputmethodservice.Keyboard._setKeyHeight3929 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "setKeyHeight", "(I)V"); 
			global::android.inputmethodservice.Keyboard._getKeyWidth3930 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getKeyWidth", "()I"); 
			global::android.inputmethodservice.Keyboard._setKeyWidth3931 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "setKeyWidth", "(I)V"); 
			global::android.inputmethodservice.Keyboard._getMinWidth3932 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getMinWidth", "()I"); 
			global::android.inputmethodservice.Keyboard._setShifted3933 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "setShifted", "(Z)Z"); 
			global::android.inputmethodservice.Keyboard._isShifted3934 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "isShifted", "()Z"); 
			global::android.inputmethodservice.Keyboard._getShiftKeyIndex3935 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getShiftKeyIndex", "()I"); 
			global::android.inputmethodservice.Keyboard._getNearestKeys3936 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "getNearestKeys", "(II)[I"); 
			global::android.inputmethodservice.Keyboard._createRowFromXml3937 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "createRowFromXml", "(Landroid/content/res/Resources;Landroid/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Row;"); 
			global::android.inputmethodservice.Keyboard._createKeyFromXml3938 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "createKeyFromXml", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandroid/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Key;"); 
			global::android.inputmethodservice.Keyboard._Keyboard3939 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
			global::android.inputmethodservice.Keyboard._Keyboard3940 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;II)V"); 
			global::android.inputmethodservice.Keyboard._Keyboard3941 = @__env.GetMethodID(global::android.inputmethodservice.Keyboard.staticClass, "<init>", "(Landroid/content/Context;ILjava/lang/CharSequence;II)V"); 
		} 
	} 
} 
