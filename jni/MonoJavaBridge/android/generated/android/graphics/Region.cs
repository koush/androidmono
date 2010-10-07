namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Region : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static Region()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Region), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.Region(@__env);
			}
		}
		protected Region(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Op : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static Op()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Region.Op), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.graphics.Region.Op(@__env);
				}
			}
			internal Op(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values3561;
			public static global::android.graphics.Region.Op[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Region.Op.staticClass, global::android.graphics.Region.Op._values3561));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3562;
			public static global::android.graphics.Region.Op valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region.Op>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Region.Op.staticClass, global::android.graphics.Region.Op._valueOf3562, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _DIFFERENCE3563;
			public static global::android.graphics.Region.Op DIFFERENCE
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _INTERSECT3564;
			public static global::android.graphics.Region.Op INTERSECT
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _REPLACE3565;
			public static global::android.graphics.Region.Op REPLACE
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _REVERSE_DIFFERENCE3566;
			public static global::android.graphics.Region.Op REVERSE_DIFFERENCE
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _UNION3567;
			public static global::android.graphics.Region.Op UNION
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _XOR3568;
			public static global::android.graphics.Region.Op XOR
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.Region.Op.staticClass = @__class;
				global::android.graphics.Region.Op._values3561 = @__env.GetStaticMethodID(global::android.graphics.Region.Op.staticClass, "values", "()[Landroid/graphics/Region/Op;");
				global::android.graphics.Region.Op._valueOf3562 = @__env.GetStaticMethodID(global::android.graphics.Region.Op.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Region$Op;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals3569;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._equals3569, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._equals3569, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty3570;
		public virtual bool isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._isEmpty3570);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._isEmpty3570);
		}
		internal static global::net.sf.jni4net.jni.MethodId _contains3571;
		public virtual bool contains(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._contains3571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._contains3571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3572;
		public virtual bool set(android.graphics.Region arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._set3572, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._set3572, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3573;
		public virtual bool set(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._set3573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._set3573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3574;
		public virtual bool set(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._set3574, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._set3574, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _union3575;
		public virtual bool union(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._union3575, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._union3575, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel3576;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Region._writeToParcel3576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._writeToParcel3576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents3577;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Region._describeContents3577);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._describeContents3577);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBounds3578;
		public virtual global::android.graphics.Rect getBounds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Region._getBounds3578));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBounds3578));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBounds3579;
		public virtual bool getBounds(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._getBounds3579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBounds3579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _translate3580;
		public virtual void translate(int arg0, int arg1, android.graphics.Region arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Region._translate3580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._translate3580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _translate3581;
		public virtual void translate(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Region._translate3581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._translate3581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _op3582;
		public virtual bool op(android.graphics.Rect arg0, android.graphics.Region arg1, android.graphics.Region.Op arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._op3582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._op3582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _op3583;
		public virtual bool op(int arg0, int arg1, int arg2, int arg3, android.graphics.Region.Op arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._op3583, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._op3583, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _op3584;
		public virtual bool op(android.graphics.Rect arg0, android.graphics.Region.Op arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._op3584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._op3584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _op3585;
		public virtual bool op(android.graphics.Region arg0, android.graphics.Region arg1, android.graphics.Region.Op arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._op3585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._op3585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _op3586;
		public virtual bool op(android.graphics.Region arg0, android.graphics.Region.Op arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._op3586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._op3586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quickReject3587;
		public virtual bool quickReject(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._quickReject3587, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickReject3587, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quickReject3588;
		public virtual bool quickReject(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._quickReject3588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickReject3588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quickReject3589;
		public virtual bool quickReject(android.graphics.Region arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._quickReject3589, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickReject3589, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEmpty3590;
		public virtual void setEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Region._setEmpty3590);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._setEmpty3590);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPath3591;
		public virtual bool setPath(android.graphics.Path arg0, android.graphics.Region arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._setPath3591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._setPath3591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isRect3592;
		public virtual bool isRect() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._isRect3592);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._isRect3592);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isComplex3593;
		public virtual bool isComplex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._isComplex3593);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._isComplex3593);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBoundaryPath3594;
		public virtual global::android.graphics.Path getBoundaryPath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Region._getBoundaryPath3594));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBoundaryPath3594));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBoundaryPath3595;
		public virtual bool getBoundaryPath(android.graphics.Path arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._getBoundaryPath3595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBoundaryPath3595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quickContains3596;
		public virtual bool quickContains(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._quickContains3596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickContains3596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quickContains3597;
		public virtual bool quickContains(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._quickContains3597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickContains3597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Region3598;
		public Region()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region3598, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Region3599;
		public Region(android.graphics.Region arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region3599, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Region3600;
		public Region(android.graphics.Rect arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region3600, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Region3601;
		public Region(int arg0, int arg1, int arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region3601, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR3602;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.Region.staticClass = @__class;
			global::android.graphics.Region._equals3569 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.graphics.Region._isEmpty3570 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "isEmpty", "()Z");
			global::android.graphics.Region._contains3571 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "contains", "(II)Z");
			global::android.graphics.Region._set3572 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "set", "(Landroid/graphics/Region;)Z");
			global::android.graphics.Region._set3573 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "set", "(IIII)Z");
			global::android.graphics.Region._set3574 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "set", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._union3575 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "union", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._writeToParcel3576 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.Region._describeContents3577 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "describeContents", "()I");
			global::android.graphics.Region._getBounds3578 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "getBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.Region._getBounds3579 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "getBounds", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._translate3580 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "translate", "(IILandroid/graphics/Region;)V");
			global::android.graphics.Region._translate3581 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "translate", "(II)V");
			global::android.graphics.Region._op3582 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Rect;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op3583 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "op", "(IIIILandroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op3584 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Rect;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op3585 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Region;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op3586 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._quickReject3587 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "quickReject", "(IIII)Z");
			global::android.graphics.Region._quickReject3588 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "quickReject", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._quickReject3589 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "quickReject", "(Landroid/graphics/Region;)Z");
			global::android.graphics.Region._setEmpty3590 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "setEmpty", "()V");
			global::android.graphics.Region._setPath3591 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "setPath", "(Landroid/graphics/Path;Landroid/graphics/Region;)Z");
			global::android.graphics.Region._isRect3592 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "isRect", "()Z");
			global::android.graphics.Region._isComplex3593 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "isComplex", "()Z");
			global::android.graphics.Region._getBoundaryPath3594 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "getBoundaryPath", "()Landroid/graphics/Path;");
			global::android.graphics.Region._getBoundaryPath3595 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "getBoundaryPath", "(Landroid/graphics/Path;)Z");
			global::android.graphics.Region._quickContains3596 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "quickContains", "(IIII)Z");
			global::android.graphics.Region._quickContains3597 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "quickContains", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._Region3598 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "<init>", "()V");
			global::android.graphics.Region._Region3599 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "<init>", "(Landroid/graphics/Region;)V");
			global::android.graphics.Region._Region3600 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
			global::android.graphics.Region._Region3601 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "<init>", "(IIII)V");
		}
	}
}
