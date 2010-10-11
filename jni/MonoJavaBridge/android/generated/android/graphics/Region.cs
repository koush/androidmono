namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Region : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Region()
		{
			InitJNI();
		}
		protected Region(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Op : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Op()
			{
				InitJNI();
			}
			internal Op(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values3748;
			public static global::android.graphics.Region.Op[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Region.Op>(@__env.CallStaticObjectMethod(android.graphics.Region.Op.staticClass, global::android.graphics.Region.Op._values3748)) as android.graphics.Region.Op[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3749;
			public static global::android.graphics.Region.Op valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Region.Op.staticClass, global::android.graphics.Region.Op._valueOf3749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Region.Op;
			}
			internal static global::MonoJavaBridge.FieldId _DIFFERENCE3750;
			public static global::android.graphics.Region.Op DIFFERENCE
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			internal static global::MonoJavaBridge.FieldId _INTERSECT3751;
			public static global::android.graphics.Region.Op INTERSECT
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			internal static global::MonoJavaBridge.FieldId _REPLACE3752;
			public static global::android.graphics.Region.Op REPLACE
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			internal static global::MonoJavaBridge.FieldId _REVERSE_DIFFERENCE3753;
			public static global::android.graphics.Region.Op REVERSE_DIFFERENCE
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNION3754;
			public static global::android.graphics.Region.Op UNION
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			internal static global::MonoJavaBridge.FieldId _XOR3755;
			public static global::android.graphics.Region.Op XOR
			{
				get
				{
					return default(global::android.graphics.Region.Op);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Region.Op.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Region$Op"));
				global::android.graphics.Region.Op._values3748 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Region.Op.staticClass, "values", "()[Landroid/graphics/Region/Op;");
				global::android.graphics.Region.Op._valueOf3749 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Region.Op.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Region$Op;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize3756;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Region._finalize3756);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._finalize3756);
		}
		internal static global::MonoJavaBridge.MethodId _equals3757;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._equals3757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._equals3757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty3758;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._isEmpty3758);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._isEmpty3758);
		}
		internal static global::MonoJavaBridge.MethodId _contains3759;
		public virtual bool contains(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._contains3759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._contains3759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set3760;
		public virtual bool set(android.graphics.Region arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._set3760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._set3760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set3761;
		public virtual bool set(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._set3761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._set3761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _set3762;
		public virtual bool set(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._set3762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._set3762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _union3763;
		public virtual bool union(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._union3763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._union3763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3764;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Region._writeToParcel3764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._writeToParcel3764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3765;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Region._describeContents3765);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._describeContents3765);
		}
		internal static global::MonoJavaBridge.MethodId _getBounds3766;
		public virtual global::android.graphics.Rect getBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Region._getBounds3766)) as android.graphics.Rect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBounds3766)) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _getBounds3767;
		public virtual bool getBounds(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._getBounds3767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBounds3767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _translate3768;
		public virtual void translate(int arg0, int arg1, android.graphics.Region arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Region._translate3768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._translate3768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _translate3769;
		public virtual void translate(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Region._translate3769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._translate3769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _op3770;
		public virtual bool op(android.graphics.Rect arg0, android.graphics.Region arg1, android.graphics.Region.Op arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._op3770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._op3770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _op3771;
		public virtual bool op(int arg0, int arg1, int arg2, int arg3, android.graphics.Region.Op arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._op3771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._op3771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _op3772;
		public virtual bool op(android.graphics.Rect arg0, android.graphics.Region.Op arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._op3772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._op3772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _op3773;
		public virtual bool op(android.graphics.Region arg0, android.graphics.Region arg1, android.graphics.Region.Op arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._op3773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._op3773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _op3774;
		public virtual bool op(android.graphics.Region arg0, android.graphics.Region.Op arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._op3774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._op3774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _quickReject3775;
		public virtual bool quickReject(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._quickReject3775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickReject3775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _quickReject3776;
		public virtual bool quickReject(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._quickReject3776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickReject3776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _quickReject3777;
		public virtual bool quickReject(android.graphics.Region arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._quickReject3777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickReject3777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEmpty3778;
		public virtual void setEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Region._setEmpty3778);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._setEmpty3778);
		}
		internal static global::MonoJavaBridge.MethodId _setPath3779;
		public virtual bool setPath(android.graphics.Path arg0, android.graphics.Region arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._setPath3779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._setPath3779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isRect3780;
		public virtual bool isRect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._isRect3780);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._isRect3780);
		}
		internal static global::MonoJavaBridge.MethodId _isComplex3781;
		public virtual bool isComplex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._isComplex3781);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._isComplex3781);
		}
		internal static global::MonoJavaBridge.MethodId _getBoundaryPath3782;
		public virtual global::android.graphics.Path getBoundaryPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Region._getBoundaryPath3782)) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBoundaryPath3782)) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _getBoundaryPath3783;
		public virtual bool getBoundaryPath(android.graphics.Path arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._getBoundaryPath3783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBoundaryPath3783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _quickContains3784;
		public virtual bool quickContains(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._quickContains3784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickContains3784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _quickContains3785;
		public virtual bool quickContains(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._quickContains3785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickContains3785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Region3786;
		public Region()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region3786);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Region3787;
		public Region(android.graphics.Region arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region3787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Region3788;
		public Region(android.graphics.Rect arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region3788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Region3789;
		public Region(int arg0, int arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region3789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3790;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Region.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Region"));
			global::android.graphics.Region._finalize3756 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "finalize", "()V");
			global::android.graphics.Region._equals3757 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.graphics.Region._isEmpty3758 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "isEmpty", "()Z");
			global::android.graphics.Region._contains3759 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "contains", "(II)Z");
			global::android.graphics.Region._set3760 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "set", "(Landroid/graphics/Region;)Z");
			global::android.graphics.Region._set3761 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "set", "(IIII)Z");
			global::android.graphics.Region._set3762 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "set", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._union3763 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "union", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._writeToParcel3764 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.Region._describeContents3765 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "describeContents", "()I");
			global::android.graphics.Region._getBounds3766 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "getBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.Region._getBounds3767 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "getBounds", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._translate3768 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "translate", "(IILandroid/graphics/Region;)V");
			global::android.graphics.Region._translate3769 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "translate", "(II)V");
			global::android.graphics.Region._op3770 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Rect;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op3771 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "op", "(IIIILandroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op3772 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Rect;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op3773 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Region;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op3774 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._quickReject3775 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "quickReject", "(IIII)Z");
			global::android.graphics.Region._quickReject3776 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "quickReject", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._quickReject3777 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "quickReject", "(Landroid/graphics/Region;)Z");
			global::android.graphics.Region._setEmpty3778 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "setEmpty", "()V");
			global::android.graphics.Region._setPath3779 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "setPath", "(Landroid/graphics/Path;Landroid/graphics/Region;)Z");
			global::android.graphics.Region._isRect3780 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "isRect", "()Z");
			global::android.graphics.Region._isComplex3781 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "isComplex", "()Z");
			global::android.graphics.Region._getBoundaryPath3782 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "getBoundaryPath", "()Landroid/graphics/Path;");
			global::android.graphics.Region._getBoundaryPath3783 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "getBoundaryPath", "(Landroid/graphics/Path;)Z");
			global::android.graphics.Region._quickContains3784 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "quickContains", "(IIII)Z");
			global::android.graphics.Region._quickContains3785 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "quickContains", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._Region3786 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "()V");
			global::android.graphics.Region._Region3787 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "(Landroid/graphics/Region;)V");
			global::android.graphics.Region._Region3788 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
			global::android.graphics.Region._Region3789 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "(IIII)V");
		}
	}
}
