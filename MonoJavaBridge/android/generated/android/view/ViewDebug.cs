namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ViewDebug : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ViewDebug(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewDebug.CapturedViewProperty_))]
		public partial interface CapturedViewProperty : java.lang.annotation.Annotation
		{
			bool retrieveReturn();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewDebug.CapturedViewProperty))]
		internal sealed partial class CapturedViewProperty_ : java.lang.Object, CapturedViewProperty
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal CapturedViewProperty_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.view.ViewDebug.CapturedViewProperty.retrieveReturn()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "retrieveReturn", "()Z", ref global::android.view.ViewDebug.CapturedViewProperty_._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.view.ViewDebug.CapturedViewProperty_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			global::java.lang.String java.lang.annotation.Annotation.toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.ViewDebug.CapturedViewProperty_._m2) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m3;
			int java.lang.annotation.Annotation.hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "hashCode", "()I", ref global::android.view.ViewDebug.CapturedViewProperty_._m3);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			global::java.lang.Class java.lang.annotation.Annotation.annotationType()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::android.view.ViewDebug.CapturedViewProperty_._m4) as java.lang.Class;
			}
			static CapturedViewProperty_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.CapturedViewProperty_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$CapturedViewProperty"));
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewDebug.ExportedProperty_))]
		public partial interface ExportedProperty : java.lang.annotation.Annotation
		{
			global::java.lang.String prefix();
			bool resolveId();
			global::android.view.ViewDebug.IntToString[] mapping();
			global::android.view.ViewDebug.IntToString[] indexMapping();
			global::android.view.ViewDebug.FlagToString[] flagMapping();
			bool deepExport();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewDebug.ExportedProperty))]
		internal sealed partial class ExportedProperty_ : java.lang.Object, ExportedProperty
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ExportedProperty_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			global::java.lang.String android.view.ViewDebug.ExportedProperty.prefix()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "prefix", "()Ljava/lang/String;", ref global::android.view.ViewDebug.ExportedProperty_._m0) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			bool android.view.ViewDebug.ExportedProperty.resolveId()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "resolveId", "()Z", ref global::android.view.ViewDebug.ExportedProperty_._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			global::android.view.ViewDebug.IntToString[] android.view.ViewDebug.ExportedProperty.mapping()
			{
				return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.view.ViewDebug.IntToString>(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "mapping", "()[Landroid/view/ViewDebug/IntToString;", ref global::android.view.ViewDebug.ExportedProperty_._m2) as android.view.ViewDebug.IntToString[];
			}
			private static global::MonoJavaBridge.MethodId _m3;
			global::android.view.ViewDebug.IntToString[] android.view.ViewDebug.ExportedProperty.indexMapping()
			{
				return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.view.ViewDebug.IntToString>(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "indexMapping", "()[Landroid/view/ViewDebug/IntToString;", ref global::android.view.ViewDebug.ExportedProperty_._m3) as android.view.ViewDebug.IntToString[];
			}
			private static global::MonoJavaBridge.MethodId _m4;
			global::android.view.ViewDebug.FlagToString[] android.view.ViewDebug.ExportedProperty.flagMapping()
			{
				return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.view.ViewDebug.FlagToString>(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "flagMapping", "()[Landroid/view/ViewDebug/FlagToString;", ref global::android.view.ViewDebug.ExportedProperty_._m4) as android.view.ViewDebug.FlagToString[];
			}
			private static global::MonoJavaBridge.MethodId _m5;
			bool android.view.ViewDebug.ExportedProperty.deepExport()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "deepExport", "()Z", ref global::android.view.ViewDebug.ExportedProperty_._m5);
			}
			private static global::MonoJavaBridge.MethodId _m6;
			bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.view.ViewDebug.ExportedProperty_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m7;
			global::java.lang.String java.lang.annotation.Annotation.toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.ViewDebug.ExportedProperty_._m7) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m8;
			int java.lang.annotation.Annotation.hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "hashCode", "()I", ref global::android.view.ViewDebug.ExportedProperty_._m8);
			}
			private static global::MonoJavaBridge.MethodId _m9;
			global::java.lang.Class java.lang.annotation.Annotation.annotationType()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.view.ViewDebug.ExportedProperty_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::android.view.ViewDebug.ExportedProperty_._m9) as java.lang.Class;
			}
			static ExportedProperty_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.ExportedProperty_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$ExportedProperty"));
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewDebug.FlagToString_))]
		public partial interface FlagToString : java.lang.annotation.Annotation
		{
			global::java.lang.String name();
			int equals();
			int mask();
			bool outputIf();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewDebug.FlagToString))]
		internal sealed partial class FlagToString_ : java.lang.Object, FlagToString
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal FlagToString_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			global::java.lang.String android.view.ViewDebug.FlagToString.name()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.ViewDebug.FlagToString_.staticClass, "name", "()Ljava/lang/String;", ref global::android.view.ViewDebug.FlagToString_._m0) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			int android.view.ViewDebug.FlagToString.equals()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewDebug.FlagToString_.staticClass, "equals", "()I", ref global::android.view.ViewDebug.FlagToString_._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			int android.view.ViewDebug.FlagToString.mask()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewDebug.FlagToString_.staticClass, "mask", "()I", ref global::android.view.ViewDebug.FlagToString_._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			bool android.view.ViewDebug.FlagToString.outputIf()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.FlagToString_.staticClass, "outputIf", "()Z", ref global::android.view.ViewDebug.FlagToString_._m3);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.FlagToString_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.view.ViewDebug.FlagToString_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			global::java.lang.String java.lang.annotation.Annotation.toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.ViewDebug.FlagToString_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.ViewDebug.FlagToString_._m5) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m6;
			int java.lang.annotation.Annotation.hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewDebug.FlagToString_.staticClass, "hashCode", "()I", ref global::android.view.ViewDebug.FlagToString_._m6);
			}
			private static global::MonoJavaBridge.MethodId _m7;
			global::java.lang.Class java.lang.annotation.Annotation.annotationType()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.view.ViewDebug.FlagToString_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::android.view.ViewDebug.FlagToString_._m7) as java.lang.Class;
			}
			static FlagToString_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.FlagToString_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$FlagToString"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class HierarchyTraceType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal HierarchyTraceType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.view.ViewDebug.HierarchyTraceType[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewDebug.HierarchyTraceType._m0.native == global::System.IntPtr.Zero)
					global::android.view.ViewDebug.HierarchyTraceType._m0 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/HierarchyTraceType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.HierarchyTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.HierarchyTraceType.staticClass, global::android.view.ViewDebug.HierarchyTraceType._m0)) as android.view.ViewDebug.HierarchyTraceType[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.view.ViewDebug.HierarchyTraceType valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewDebug.HierarchyTraceType._m1.native == global::System.IntPtr.Zero)
					global::android.view.ViewDebug.HierarchyTraceType._m1 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$HierarchyTraceType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.HierarchyTraceType.staticClass, global::android.view.ViewDebug.HierarchyTraceType._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewDebug.HierarchyTraceType;
			}
			internal static global::MonoJavaBridge.FieldId _BUILD_CACHE5712;
			public static global::android.view.ViewDebug.HierarchyTraceType BUILD_CACHE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _BUILD_CACHE5712)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DRAW5713;
			public static global::android.view.ViewDebug.HierarchyTraceType DRAW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _DRAW5713)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVALIDATE5714;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _INVALIDATE5714)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVALIDATE_CHILD5715;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _INVALIDATE_CHILD5715)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVALIDATE_CHILD_IN_PARENT5716;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD_IN_PARENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _INVALIDATE_CHILD_IN_PARENT5716)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON_LAYOUT5717;
			public static global::android.view.ViewDebug.HierarchyTraceType ON_LAYOUT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _ON_LAYOUT5717)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON_MEASURE5718;
			public static global::android.view.ViewDebug.HierarchyTraceType ON_MEASURE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _ON_MEASURE5718)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _REQUEST_LAYOUT5719;
			public static global::android.view.ViewDebug.HierarchyTraceType REQUEST_LAYOUT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _REQUEST_LAYOUT5719)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			static HierarchyTraceType()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.HierarchyTraceType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$HierarchyTraceType"));
				global::android.view.ViewDebug.HierarchyTraceType._BUILD_CACHE5712 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "BUILD_CACHE", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._DRAW5713 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "DRAW", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._INVALIDATE5714 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "INVALIDATE", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._INVALIDATE_CHILD5715 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "INVALIDATE_CHILD", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._INVALIDATE_CHILD_IN_PARENT5716 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "INVALIDATE_CHILD_IN_PARENT", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._ON_LAYOUT5717 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "ON_LAYOUT", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._ON_MEASURE5718 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "ON_MEASURE", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._REQUEST_LAYOUT5719 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "REQUEST_LAYOUT", "Landroid/view/ViewDebug$HierarchyTraceType;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewDebug.IntToString_))]
		public partial interface IntToString : java.lang.annotation.Annotation
		{
			int from();
			global::java.lang.String to();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewDebug.IntToString))]
		internal sealed partial class IntToString_ : java.lang.Object, IntToString
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal IntToString_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			int android.view.ViewDebug.IntToString.from()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewDebug.IntToString_.staticClass, "from", "()I", ref global::android.view.ViewDebug.IntToString_._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			global::java.lang.String android.view.ViewDebug.IntToString.to()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.ViewDebug.IntToString_.staticClass, "to", "()Ljava/lang/String;", ref global::android.view.ViewDebug.IntToString_._m1) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewDebug.IntToString_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.view.ViewDebug.IntToString_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			global::java.lang.String java.lang.annotation.Annotation.toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.ViewDebug.IntToString_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.ViewDebug.IntToString_._m3) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m4;
			int java.lang.annotation.Annotation.hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewDebug.IntToString_.staticClass, "hashCode", "()I", ref global::android.view.ViewDebug.IntToString_._m4);
			}
			private static global::MonoJavaBridge.MethodId _m5;
			global::java.lang.Class java.lang.annotation.Annotation.annotationType()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.view.ViewDebug.IntToString_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::android.view.ViewDebug.IntToString_._m5) as java.lang.Class;
			}
			static IntToString_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.IntToString_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$IntToString"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class RecyclerTraceType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal RecyclerTraceType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.view.ViewDebug.RecyclerTraceType[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewDebug.RecyclerTraceType._m0.native == global::System.IntPtr.Zero)
					global::android.view.ViewDebug.RecyclerTraceType._m0 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/RecyclerTraceType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.RecyclerTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.RecyclerTraceType.staticClass, global::android.view.ViewDebug.RecyclerTraceType._m0)) as android.view.ViewDebug.RecyclerTraceType[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.view.ViewDebug.RecyclerTraceType valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewDebug.RecyclerTraceType._m1.native == global::System.IntPtr.Zero)
					global::android.view.ViewDebug.RecyclerTraceType._m1 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$RecyclerTraceType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.RecyclerTraceType.staticClass, global::android.view.ViewDebug.RecyclerTraceType._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewDebug.RecyclerTraceType;
			}
			internal static global::MonoJavaBridge.FieldId _BIND_VIEW5720;
			public static global::android.view.ViewDebug.RecyclerTraceType BIND_VIEW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _BIND_VIEW5720)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MOVE_FROM_ACTIVE_TO_SCRAP_HEAP5721;
			public static global::android.view.ViewDebug.RecyclerTraceType MOVE_FROM_ACTIVE_TO_SCRAP_HEAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _MOVE_FROM_ACTIVE_TO_SCRAP_HEAP5721)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MOVE_TO_SCRAP_HEAP5722;
			public static global::android.view.ViewDebug.RecyclerTraceType MOVE_TO_SCRAP_HEAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _MOVE_TO_SCRAP_HEAP5722)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEW_VIEW5723;
			public static global::android.view.ViewDebug.RecyclerTraceType NEW_VIEW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _NEW_VIEW5723)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RECYCLE_FROM_ACTIVE_HEAP5724;
			public static global::android.view.ViewDebug.RecyclerTraceType RECYCLE_FROM_ACTIVE_HEAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _RECYCLE_FROM_ACTIVE_HEAP5724)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RECYCLE_FROM_SCRAP_HEAP5725;
			public static global::android.view.ViewDebug.RecyclerTraceType RECYCLE_FROM_SCRAP_HEAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _RECYCLE_FROM_SCRAP_HEAP5725)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			static RecyclerTraceType()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.RecyclerTraceType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$RecyclerTraceType"));
				global::android.view.ViewDebug.RecyclerTraceType._BIND_VIEW5720 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "BIND_VIEW", "Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._MOVE_FROM_ACTIVE_TO_SCRAP_HEAP5721 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "MOVE_FROM_ACTIVE_TO_SCRAP_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._MOVE_TO_SCRAP_HEAP5722 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "MOVE_TO_SCRAP_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._NEW_VIEW5723 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "NEW_VIEW", "Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._RECYCLE_FROM_ACTIVE_HEAP5724 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "RECYCLE_FROM_ACTIVE_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._RECYCLE_FROM_SCRAP_HEAP5725 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "RECYCLE_FROM_SCRAP_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void trace(android.view.View arg0, android.view.ViewDebug.RecyclerTraceType arg1, int[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._m0.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._m0 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$RecyclerTraceType;[I)V");
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void trace(android.view.View arg0, android.view.ViewDebug.HierarchyTraceType arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._m1.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._m1 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$HierarchyTraceType;)V");
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void startRecyclerTracing(java.lang.String arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._m2.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._m2 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "startRecyclerTracing", "(Ljava/lang/String;Landroid/view/View;)V");
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void stopRecyclerTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._m3.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._m3 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "stopRecyclerTracing", "()V");
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void startHierarchyTracing(java.lang.String arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._m4.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._m4 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "startHierarchyTracing", "(Ljava/lang/String;Landroid/view/View;)V");
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void stopHierarchyTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._m5.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._m5 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "stopHierarchyTracing", "()V");
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void dumpCapturedView(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._m6.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._m6 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "dumpCapturedView", "(Ljava/lang/String;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public ViewDebug() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewDebug._m7.native == global::System.IntPtr.Zero)
				global::android.view.ViewDebug._m7 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._m7);
			Init(@__env, handle);
		}
		public static bool TRACE_HIERARCHY
		{
			get
			{
				return false;
			}
		}
		public static bool TRACE_RECYCLER
		{
			get
			{
				return false;
			}
		}
		static ViewDebug()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewDebug.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug"));
		}
	}
}
