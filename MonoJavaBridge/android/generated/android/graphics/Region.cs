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
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.Region.Op[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Region.Op._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.Region.Op._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Region.Op.staticClass, "values", "()[Landroid/graphics/Region/Op;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Region.Op>(@__env.CallStaticObjectMethod(android.graphics.Region.Op.staticClass, global::android.graphics.Region.Op._m0)) as android.graphics.Region.Op[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.Region.Op valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Region.Op._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.Region.Op._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Region.Op.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Region$Op;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.CallStaticObjectMethod(android.graphics.Region.Op.staticClass, global::android.graphics.Region.Op._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Region.Op;
			}
			internal static global::MonoJavaBridge.FieldId _DIFFERENCE2401;
			public static global::android.graphics.Region.Op DIFFERENCE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _DIFFERENCE2401)) as android.graphics.Region.Op;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INTERSECT2402;
			public static global::android.graphics.Region.Op INTERSECT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _INTERSECT2402)) as android.graphics.Region.Op;
				}
			}
			internal static global::MonoJavaBridge.FieldId _REPLACE2403;
			public static global::android.graphics.Region.Op REPLACE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _REPLACE2403)) as android.graphics.Region.Op;
				}
			}
			internal static global::MonoJavaBridge.FieldId _REVERSE_DIFFERENCE2404;
			public static global::android.graphics.Region.Op REVERSE_DIFFERENCE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _REVERSE_DIFFERENCE2404)) as android.graphics.Region.Op;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNION2405;
			public static global::android.graphics.Region.Op UNION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _UNION2405)) as android.graphics.Region.Op;
				}
			}
			internal static global::MonoJavaBridge.FieldId _XOR2406;
			public static global::android.graphics.Region.Op XOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _XOR2406)) as android.graphics.Region.Op;
				}
			}
			static Op()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Region.Op.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Region$Op"));
				global::android.graphics.Region.Op._DIFFERENCE2401 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "DIFFERENCE", "Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._INTERSECT2402 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "INTERSECT", "Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._REPLACE2403 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "REPLACE", "Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._REVERSE_DIFFERENCE2404 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "REVERSE_DIFFERENCE", "Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._UNION2405 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "UNION", "Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._XOR2406 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "XOR", "Landroid/graphics/Region$Op;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Region.staticClass, "finalize", "()V", ref global::android.graphics.Region._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.graphics.Region._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "isEmpty", "()Z", ref global::android.graphics.Region._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool contains(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "contains", "(II)Z", ref global::android.graphics.Region._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool set(android.graphics.Region arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "set", "(Landroid/graphics/Region;)Z", ref global::android.graphics.Region._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool set(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "set", "(IIII)Z", ref global::android.graphics.Region._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool set(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "set", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.Region._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool union(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "union", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.Region._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Region.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.graphics.Region._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Region.staticClass, "describeContents", "()I", ref global::android.graphics.Region._m9);
		}
		public new global::android.graphics.Rect Bounds
		{
			get
			{
				return getBounds();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.graphics.Rect getBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Rect>(this, global::android.graphics.Region.staticClass, "getBounds", "()Landroid/graphics/Rect;", ref global::android.graphics.Region._m10) as android.graphics.Rect;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool getBounds(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "getBounds", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.Region._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void translate(int arg0, int arg1, android.graphics.Region arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Region.staticClass, "translate", "(IILandroid/graphics/Region;)V", ref global::android.graphics.Region._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void translate(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Region.staticClass, "translate", "(II)V", ref global::android.graphics.Region._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool op(android.graphics.Rect arg0, android.graphics.Region arg1, android.graphics.Region.Op arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Rect;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z", ref global::android.graphics.Region._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool op(int arg0, int arg1, int arg2, int arg3, android.graphics.Region.Op arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "op", "(IIIILandroid/graphics/Region$Op;)Z", ref global::android.graphics.Region._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool op(android.graphics.Rect arg0, android.graphics.Region.Op arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Rect;Landroid/graphics/Region$Op;)Z", ref global::android.graphics.Region._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool op(android.graphics.Region arg0, android.graphics.Region arg1, android.graphics.Region.Op arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Region;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z", ref global::android.graphics.Region._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool op(android.graphics.Region arg0, android.graphics.Region.Op arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z", ref global::android.graphics.Region._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool quickReject(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "quickReject", "(IIII)Z", ref global::android.graphics.Region._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool quickReject(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "quickReject", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.Region._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool quickReject(android.graphics.Region arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "quickReject", "(Landroid/graphics/Region;)Z", ref global::android.graphics.Region._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setEmpty()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Region.staticClass, "setEmpty", "()V", ref global::android.graphics.Region._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool setPath(android.graphics.Path arg0, android.graphics.Region arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "setPath", "(Landroid/graphics/Path;Landroid/graphics/Region;)Z", ref global::android.graphics.Region._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool isRect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "isRect", "()Z", ref global::android.graphics.Region._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual bool isComplex()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "isComplex", "()Z", ref global::android.graphics.Region._m25);
		}
		public new global::android.graphics.Path BoundaryPath
		{
			get
			{
				return getBoundaryPath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::android.graphics.Path getBoundaryPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Region.staticClass, "getBoundaryPath", "()Landroid/graphics/Path;", ref global::android.graphics.Region._m26) as android.graphics.Path;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool getBoundaryPath(android.graphics.Path arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "getBoundaryPath", "(Landroid/graphics/Path;)Z", ref global::android.graphics.Region._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual bool quickContains(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "quickContains", "(IIII)Z", ref global::android.graphics.Region._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool quickContains(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Region.staticClass, "quickContains", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.Region._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public Region() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Region._m30.native == global::System.IntPtr.Zero)
				global::android.graphics.Region._m30 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._m30);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public Region(android.graphics.Region arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Region._m31.native == global::System.IntPtr.Zero)
				global::android.graphics.Region._m31 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "(Landroid/graphics/Region;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public Region(android.graphics.Rect arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Region._m32.native == global::System.IntPtr.Zero)
				global::android.graphics.Region._m32 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public Region(int arg0, int arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Region._m33.native == global::System.IntPtr.Zero)
				global::android.graphics.Region._m33 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "(IIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2407;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.graphics.Region.staticClass, _CREATOR2407)) as android.os.Parcelable_Creator;
			}
		}
		static Region()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Region.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Region"));
			global::android.graphics.Region._CREATOR2407 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
