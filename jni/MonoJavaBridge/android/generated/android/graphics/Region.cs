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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3362;
			public static global::android.graphics.Region.Op valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region.Op>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Region.Op.staticClass, global::android.graphics.Region.Op._valueOf3362, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _values3363;
			public static global::android.graphics.Region.Op[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Region.Op.staticClass, global::android.graphics.Region.Op._values3363));
			}
			internal static global::net.sf.jni4net.jni.FieldId _DIFFERENCE3364;
			public static global::android.graphics.Region.Op DIFFERENCE
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _INTERSECT3365;
			public static global::android.graphics.Region.Op INTERSECT
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _REPLACE3366;
			public static global::android.graphics.Region.Op REPLACE
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _REVERSE_DIFFERENCE3367;
			public static global::android.graphics.Region.Op REVERSE_DIFFERENCE
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _UNION3368;
			public static global::android.graphics.Region.Op UNION
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _XOR3369;
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
				global::android.graphics.Region.Op._valueOf3362 = @__env.GetStaticMethodID(global::android.graphics.Region.Op.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._values3363 = @__env.GetStaticMethodID(global::android.graphics.Region.Op.staticClass, "values", "()[Landroid/graphics/Region/Op;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals3370;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._equals3370, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._equals3370, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty3371;
		public virtual bool isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._isEmpty3371);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._isEmpty3371);
		}
		internal static global::net.sf.jni4net.jni.MethodId _contains3372;
		public virtual bool contains(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._contains3372, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._contains3372, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3373;
		public virtual bool set(android.graphics.Region arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._set3373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._set3373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3374;
		public virtual bool set(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._set3374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._set3374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3375;
		public virtual bool set(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._set3375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._set3375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _union3376;
		public virtual bool union(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._union3376, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._union3376, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel3377;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Region._writeToParcel3377, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._writeToParcel3377, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents3378;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Region._describeContents3378);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._describeContents3378);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBounds3379;
		public virtual global::android.graphics.Rect getBounds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Region._getBounds3379));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBounds3379));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBounds3380;
		public virtual bool getBounds(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._getBounds3380, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBounds3380, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _translate3381;
		public virtual void translate(int arg0, int arg1, android.graphics.Region arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Region._translate3381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._translate3381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _translate3382;
		public virtual void translate(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Region._translate3382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._translate3382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _op3383;
		public virtual bool op(android.graphics.Rect arg0, android.graphics.Region arg1, android.graphics.Region.Op arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._op3383, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._op3383, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _op3384;
		public virtual bool op(int arg0, int arg1, int arg2, int arg3, android.graphics.Region.Op arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._op3384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._op3384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _op3385;
		public virtual bool op(android.graphics.Rect arg0, android.graphics.Region.Op arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._op3385, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._op3385, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _op3386;
		public virtual bool op(android.graphics.Region arg0, android.graphics.Region arg1, android.graphics.Region.Op arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._op3386, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._op3386, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _op3387;
		public virtual bool op(android.graphics.Region arg0, android.graphics.Region.Op arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._op3387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._op3387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quickReject3388;
		public virtual bool quickReject(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._quickReject3388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickReject3388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quickReject3389;
		public virtual bool quickReject(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._quickReject3389, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickReject3389, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quickReject3390;
		public virtual bool quickReject(android.graphics.Region arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._quickReject3390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickReject3390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEmpty3391;
		public virtual void setEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Region._setEmpty3391);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._setEmpty3391);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPath3392;
		public virtual bool setPath(android.graphics.Path arg0, android.graphics.Region arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._setPath3392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._setPath3392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isRect3393;
		public virtual bool isRect() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._isRect3393);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._isRect3393);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isComplex3394;
		public virtual bool isComplex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._isComplex3394);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._isComplex3394);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBoundaryPath3395;
		public virtual global::android.graphics.Path getBoundaryPath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Region._getBoundaryPath3395));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBoundaryPath3395));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBoundaryPath3396;
		public virtual bool getBoundaryPath(android.graphics.Path arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._getBoundaryPath3396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBoundaryPath3396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quickContains3397;
		public virtual bool quickContains(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._quickContains3397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickContains3397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _quickContains3398;
		public virtual bool quickContains(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Region._quickContains3398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickContains3398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Region3399;
		public Region()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region3399, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Region3400;
		public Region(android.graphics.Region arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region3400, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Region3401;
		public Region(android.graphics.Rect arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region3401, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Region3402;
		public Region(int arg0, int arg1, int arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region3402, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR3403;
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
			global::android.graphics.Region._equals3370 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.graphics.Region._isEmpty3371 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "isEmpty", "()Z");
			global::android.graphics.Region._contains3372 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "contains", "(II)Z");
			global::android.graphics.Region._set3373 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "set", "(Landroid/graphics/Region;)Z");
			global::android.graphics.Region._set3374 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "set", "(IIII)Z");
			global::android.graphics.Region._set3375 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "set", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._union3376 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "union", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._writeToParcel3377 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.Region._describeContents3378 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "describeContents", "()I");
			global::android.graphics.Region._getBounds3379 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "getBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.Region._getBounds3380 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "getBounds", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._translate3381 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "translate", "(IILandroid/graphics/Region;)V");
			global::android.graphics.Region._translate3382 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "translate", "(II)V");
			global::android.graphics.Region._op3383 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Rect;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op3384 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "op", "(IIIILandroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op3385 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Rect;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op3386 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Region;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op3387 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._quickReject3388 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "quickReject", "(IIII)Z");
			global::android.graphics.Region._quickReject3389 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "quickReject", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._quickReject3390 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "quickReject", "(Landroid/graphics/Region;)Z");
			global::android.graphics.Region._setEmpty3391 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "setEmpty", "()V");
			global::android.graphics.Region._setPath3392 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "setPath", "(Landroid/graphics/Path;Landroid/graphics/Region;)Z");
			global::android.graphics.Region._isRect3393 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "isRect", "()Z");
			global::android.graphics.Region._isComplex3394 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "isComplex", "()Z");
			global::android.graphics.Region._getBoundaryPath3395 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "getBoundaryPath", "()Landroid/graphics/Path;");
			global::android.graphics.Region._getBoundaryPath3396 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "getBoundaryPath", "(Landroid/graphics/Path;)Z");
			global::android.graphics.Region._quickContains3397 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "quickContains", "(IIII)Z");
			global::android.graphics.Region._quickContains3398 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "quickContains", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._Region3399 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "<init>", "()V");
			global::android.graphics.Region._Region3400 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "<init>", "(Landroid/graphics/Region;)V");
			global::android.graphics.Region._Region3401 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
			global::android.graphics.Region._Region3402 = @__env.GetMethodID(global::android.graphics.Region.staticClass, "<init>", "(IIII)V");
		}
	}
}
