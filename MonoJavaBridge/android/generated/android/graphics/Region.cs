namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Region : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Region(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Op : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Op(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values5748;
			public static global::android.graphics.Region.Op[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Region.Op>(@__env.CallStaticObjectMethod(android.graphics.Region.Op.staticClass, global::android.graphics.Region.Op._values5748)) as android.graphics.Region.Op[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5749;
			public static global::android.graphics.Region.Op valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.CallStaticObjectMethod(android.graphics.Region.Op.staticClass, global::android.graphics.Region.Op._valueOf5749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Region.Op;
			}
			internal static global::MonoJavaBridge.FieldId _DIFFERENCE5750;
			public static global::android.graphics.Region.Op DIFFERENCE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _DIFFERENCE5750)) as android.graphics.Region.Op;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INTERSECT5751;
			public static global::android.graphics.Region.Op INTERSECT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _INTERSECT5751)) as android.graphics.Region.Op;
				}
			}
			internal static global::MonoJavaBridge.FieldId _REPLACE5752;
			public static global::android.graphics.Region.Op REPLACE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _REPLACE5752)) as android.graphics.Region.Op;
				}
			}
			internal static global::MonoJavaBridge.FieldId _REVERSE_DIFFERENCE5753;
			public static global::android.graphics.Region.Op REVERSE_DIFFERENCE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _REVERSE_DIFFERENCE5753)) as android.graphics.Region.Op;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNION5754;
			public static global::android.graphics.Region.Op UNION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _UNION5754)) as android.graphics.Region.Op;
				}
			}
			internal static global::MonoJavaBridge.FieldId _XOR5755;
			public static global::android.graphics.Region.Op XOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _XOR5755)) as android.graphics.Region.Op;
				}
			}
			static Op()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Region.Op.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Region$Op"));
				global::android.graphics.Region.Op._values5748 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Region.Op.staticClass, "values", "()[Landroid/graphics/Region/Op;");
				global::android.graphics.Region.Op._valueOf5749 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Region.Op.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._DIFFERENCE5750 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "DIFFERENCE", "Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._INTERSECT5751 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "INTERSECT", "Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._REPLACE5752 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "REPLACE", "Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._REVERSE_DIFFERENCE5753 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "REVERSE_DIFFERENCE", "Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._UNION5754 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "UNION", "Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._XOR5755 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "XOR", "Landroid/graphics/Region$Op;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize5756;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._finalize5756);
		}
		internal static global::MonoJavaBridge.MethodId _equals5757;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._equals5757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty5758;
		public virtual bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._isEmpty5758);
		}
		internal static global::MonoJavaBridge.MethodId _contains5759;
		public virtual bool contains(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._contains5759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set5760;
		public virtual bool set(android.graphics.Region arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._set5760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set5761;
		public virtual bool set(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._set5761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _set5762;
		public virtual bool set(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._set5762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _union5763;
		public virtual bool union(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._union5763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5764;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._writeToParcel5764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents5765;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._describeContents5765);
		}
		public new global::android.graphics.Rect Bounds
		{
			get
			{
				return getBounds();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBounds5766;
		public virtual global::android.graphics.Rect getBounds()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBounds5766)) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _getBounds5767;
		public virtual bool getBounds(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBounds5767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _translate5768;
		public virtual void translate(int arg0, int arg1, android.graphics.Region arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._translate5768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _translate5769;
		public virtual void translate(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._translate5769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _op5770;
		public virtual bool op(android.graphics.Rect arg0, android.graphics.Region arg1, android.graphics.Region.Op arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._op5770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _op5771;
		public virtual bool op(int arg0, int arg1, int arg2, int arg3, android.graphics.Region.Op arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._op5771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _op5772;
		public virtual bool op(android.graphics.Rect arg0, android.graphics.Region.Op arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._op5772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _op5773;
		public virtual bool op(android.graphics.Region arg0, android.graphics.Region arg1, android.graphics.Region.Op arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._op5773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _op5774;
		public virtual bool op(android.graphics.Region arg0, android.graphics.Region.Op arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._op5774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _quickReject5775;
		public virtual bool quickReject(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickReject5775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _quickReject5776;
		public virtual bool quickReject(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickReject5776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _quickReject5777;
		public virtual bool quickReject(android.graphics.Region arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickReject5777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEmpty5778;
		public virtual void setEmpty()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._setEmpty5778);
		}
		internal static global::MonoJavaBridge.MethodId _setPath5779;
		public virtual bool setPath(android.graphics.Path arg0, android.graphics.Region arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._setPath5779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isRect5780;
		public virtual bool isRect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._isRect5780);
		}
		internal static global::MonoJavaBridge.MethodId _isComplex5781;
		public virtual bool isComplex()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._isComplex5781);
		}
		public new global::android.graphics.Path BoundaryPath
		{
			get
			{
				return getBoundaryPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBoundaryPath5782;
		public virtual global::android.graphics.Path getBoundaryPath()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBoundaryPath5782)) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _getBoundaryPath5783;
		public virtual bool getBoundaryPath(android.graphics.Path arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBoundaryPath5783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _quickContains5784;
		public virtual bool quickContains(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickContains5784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _quickContains5785;
		public virtual bool quickContains(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickContains5785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Region5786;
		public Region() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region5786);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Region5787;
		public Region(android.graphics.Region arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region5787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Region5788;
		public Region(android.graphics.Rect arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region5788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Region5789;
		public Region(int arg0, int arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region5789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR5790;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.graphics.Region.staticClass, _CREATOR5790)) as android.os.Parcelable_Creator;
			}
		}
		static Region()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Region.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Region"));
			global::android.graphics.Region._finalize5756 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "finalize", "()V");
			global::android.graphics.Region._equals5757 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.graphics.Region._isEmpty5758 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "isEmpty", "()Z");
			global::android.graphics.Region._contains5759 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "contains", "(II)Z");
			global::android.graphics.Region._set5760 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "set", "(Landroid/graphics/Region;)Z");
			global::android.graphics.Region._set5761 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "set", "(IIII)Z");
			global::android.graphics.Region._set5762 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "set", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._union5763 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "union", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._writeToParcel5764 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.Region._describeContents5765 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "describeContents", "()I");
			global::android.graphics.Region._getBounds5766 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "getBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.Region._getBounds5767 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "getBounds", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._translate5768 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "translate", "(IILandroid/graphics/Region;)V");
			global::android.graphics.Region._translate5769 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "translate", "(II)V");
			global::android.graphics.Region._op5770 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Rect;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op5771 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "op", "(IIIILandroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op5772 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Rect;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op5773 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Region;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op5774 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._quickReject5775 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "quickReject", "(IIII)Z");
			global::android.graphics.Region._quickReject5776 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "quickReject", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._quickReject5777 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "quickReject", "(Landroid/graphics/Region;)Z");
			global::android.graphics.Region._setEmpty5778 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "setEmpty", "()V");
			global::android.graphics.Region._setPath5779 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "setPath", "(Landroid/graphics/Path;Landroid/graphics/Region;)Z");
			global::android.graphics.Region._isRect5780 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "isRect", "()Z");
			global::android.graphics.Region._isComplex5781 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "isComplex", "()Z");
			global::android.graphics.Region._getBoundaryPath5782 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "getBoundaryPath", "()Landroid/graphics/Path;");
			global::android.graphics.Region._getBoundaryPath5783 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "getBoundaryPath", "(Landroid/graphics/Path;)Z");
			global::android.graphics.Region._quickContains5784 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "quickContains", "(IIII)Z");
			global::android.graphics.Region._quickContains5785 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "quickContains", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._Region5786 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "()V");
			global::android.graphics.Region._Region5787 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "(Landroid/graphics/Region;)V");
			global::android.graphics.Region._Region5788 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
			global::android.graphics.Region._Region5789 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "(IIII)V");
			global::android.graphics.Region._CREATOR5790 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
