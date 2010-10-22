namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ViewDebug : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ViewDebug()
		{
			InitJNI();
		}
		protected ViewDebug(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewDebug.CapturedViewProperty_))]
		public partial interface CapturedViewProperty : java.lang.annotation.Annotation
		{
			bool retrieveReturn();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewDebug.CapturedViewProperty))]
		public sealed partial class CapturedViewProperty_ : java.lang.Object, CapturedViewProperty
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static CapturedViewProperty_()
			{
				InitJNI();
			}
			internal CapturedViewProperty_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _retrieveReturn14903;
			 bool android.view.ViewDebug.CapturedViewProperty.retrieveReturn() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_._retrieveReturn14903);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, global::android.view.ViewDebug.CapturedViewProperty_._retrieveReturn14903);
			}
			internal static global::MonoJavaBridge.MethodId _equals14904;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_._equals14904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, global::android.view.ViewDebug.CapturedViewProperty_._equals14904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString14905;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_._toString14905)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, global::android.view.ViewDebug.CapturedViewProperty_._toString14905)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode14906;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_._hashCode14906);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, global::android.view.ViewDebug.CapturedViewProperty_._hashCode14906);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType14907;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_._annotationType14907)) as java.lang.Class;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, global::android.view.ViewDebug.CapturedViewProperty_._annotationType14907)) as java.lang.Class;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.CapturedViewProperty_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$CapturedViewProperty"));
				global::android.view.ViewDebug.CapturedViewProperty_._retrieveReturn14903 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "retrieveReturn", "()Z");
				global::android.view.ViewDebug.CapturedViewProperty_._equals14904 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.CapturedViewProperty_._toString14905 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.CapturedViewProperty_._hashCode14906 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "hashCode", "()I");
				global::android.view.ViewDebug.CapturedViewProperty_._annotationType14907 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "annotationType", "()Ljava/lang/Class;");
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
		public sealed partial class ExportedProperty_ : java.lang.Object, ExportedProperty
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ExportedProperty_()
			{
				InitJNI();
			}
			internal ExportedProperty_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _prefix14908;
			 global::java.lang.String android.view.ViewDebug.ExportedProperty.prefix() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._prefix14908)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._prefix14908)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _resolveId14909;
			 bool android.view.ViewDebug.ExportedProperty.resolveId() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._resolveId14909);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._resolveId14909);
			}
			internal static global::MonoJavaBridge.MethodId _mapping14910;
			 global::android.view.ViewDebug.IntToString[] android.view.ViewDebug.ExportedProperty.mapping() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.IntToString>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._mapping14910)) as android.view.ViewDebug.IntToString[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.IntToString>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._mapping14910)) as android.view.ViewDebug.IntToString[];
			}
			internal static global::MonoJavaBridge.MethodId _indexMapping14911;
			 global::android.view.ViewDebug.IntToString[] android.view.ViewDebug.ExportedProperty.indexMapping() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.IntToString>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._indexMapping14911)) as android.view.ViewDebug.IntToString[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.IntToString>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._indexMapping14911)) as android.view.ViewDebug.IntToString[];
			}
			internal static global::MonoJavaBridge.MethodId _flagMapping14912;
			 global::android.view.ViewDebug.FlagToString[] android.view.ViewDebug.ExportedProperty.flagMapping() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.FlagToString>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._flagMapping14912)) as android.view.ViewDebug.FlagToString[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.FlagToString>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._flagMapping14912)) as android.view.ViewDebug.FlagToString[];
			}
			internal static global::MonoJavaBridge.MethodId _deepExport14913;
			 bool android.view.ViewDebug.ExportedProperty.deepExport() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._deepExport14913);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._deepExport14913);
			}
			internal static global::MonoJavaBridge.MethodId _equals14914;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._equals14914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._equals14914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString14915;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._toString14915)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._toString14915)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode14916;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._hashCode14916);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._hashCode14916);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType14917;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._annotationType14917)) as java.lang.Class;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._annotationType14917)) as java.lang.Class;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.ExportedProperty_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$ExportedProperty"));
				global::android.view.ViewDebug.ExportedProperty_._prefix14908 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "prefix", "()Ljava/lang/String;");
				global::android.view.ViewDebug.ExportedProperty_._resolveId14909 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "resolveId", "()Z");
				global::android.view.ViewDebug.ExportedProperty_._mapping14910 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "mapping", "()[Landroid/view/ViewDebug/IntToString;");
				global::android.view.ViewDebug.ExportedProperty_._indexMapping14911 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "indexMapping", "()[Landroid/view/ViewDebug/IntToString;");
				global::android.view.ViewDebug.ExportedProperty_._flagMapping14912 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "flagMapping", "()[Landroid/view/ViewDebug/FlagToString;");
				global::android.view.ViewDebug.ExportedProperty_._deepExport14913 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "deepExport", "()Z");
				global::android.view.ViewDebug.ExportedProperty_._equals14914 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.ExportedProperty_._toString14915 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.ExportedProperty_._hashCode14916 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "hashCode", "()I");
				global::android.view.ViewDebug.ExportedProperty_._annotationType14917 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "annotationType", "()Ljava/lang/Class;");
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
		public sealed partial class FlagToString_ : java.lang.Object, FlagToString
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static FlagToString_()
			{
				InitJNI();
			}
			internal FlagToString_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _name14918;
			 global::java.lang.String android.view.ViewDebug.FlagToString.name() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._name14918)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._name14918)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _equals14919;
			 int android.view.ViewDebug.FlagToString.equals() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._equals14919);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._equals14919);
			}
			internal static global::MonoJavaBridge.MethodId _mask14920;
			 int android.view.ViewDebug.FlagToString.mask() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._mask14920);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._mask14920);
			}
			internal static global::MonoJavaBridge.MethodId _outputIf14921;
			 bool android.view.ViewDebug.FlagToString.outputIf() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._outputIf14921);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._outputIf14921);
			}
			internal static global::MonoJavaBridge.MethodId _equals14922;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._equals14922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._equals14922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString14923;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._toString14923)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._toString14923)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode14924;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._hashCode14924);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._hashCode14924);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType14925;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._annotationType14925)) as java.lang.Class;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._annotationType14925)) as java.lang.Class;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.FlagToString_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$FlagToString"));
				global::android.view.ViewDebug.FlagToString_._name14918 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "name", "()Ljava/lang/String;");
				global::android.view.ViewDebug.FlagToString_._equals14919 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "equals", "()I");
				global::android.view.ViewDebug.FlagToString_._mask14920 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "mask", "()I");
				global::android.view.ViewDebug.FlagToString_._outputIf14921 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "outputIf", "()Z");
				global::android.view.ViewDebug.FlagToString_._equals14922 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.FlagToString_._toString14923 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.FlagToString_._hashCode14924 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "hashCode", "()I");
				global::android.view.ViewDebug.FlagToString_._annotationType14925 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "annotationType", "()Ljava/lang/Class;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class HierarchyTraceType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static HierarchyTraceType()
			{
				InitJNI();
			}
			internal HierarchyTraceType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values14926;
			public static global::android.view.ViewDebug.HierarchyTraceType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.HierarchyTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.HierarchyTraceType.staticClass, global::android.view.ViewDebug.HierarchyTraceType._values14926)) as android.view.ViewDebug.HierarchyTraceType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf14927;
			public static global::android.view.ViewDebug.HierarchyTraceType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.HierarchyTraceType.staticClass, global::android.view.ViewDebug.HierarchyTraceType._valueOf14927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewDebug.HierarchyTraceType;
			}
			internal static global::MonoJavaBridge.FieldId _BUILD_CACHE14928;
			public static global::android.view.ViewDebug.HierarchyTraceType BUILD_CACHE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _BUILD_CACHE14928)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DRAW14929;
			public static global::android.view.ViewDebug.HierarchyTraceType DRAW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _DRAW14929)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVALIDATE14930;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _INVALIDATE14930)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVALIDATE_CHILD14931;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _INVALIDATE_CHILD14931)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVALIDATE_CHILD_IN_PARENT14932;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD_IN_PARENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _INVALIDATE_CHILD_IN_PARENT14932)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON_LAYOUT14933;
			public static global::android.view.ViewDebug.HierarchyTraceType ON_LAYOUT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _ON_LAYOUT14933)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON_MEASURE14934;
			public static global::android.view.ViewDebug.HierarchyTraceType ON_MEASURE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _ON_MEASURE14934)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _REQUEST_LAYOUT14935;
			public static global::android.view.ViewDebug.HierarchyTraceType REQUEST_LAYOUT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.HierarchyTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.HierarchyTraceType.staticClass, _REQUEST_LAYOUT14935)) as android.view.ViewDebug.HierarchyTraceType;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.HierarchyTraceType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$HierarchyTraceType"));
				global::android.view.ViewDebug.HierarchyTraceType._values14926 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._valueOf14927 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._BUILD_CACHE14928 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "BUILD_CACHE", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._DRAW14929 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "DRAW", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._INVALIDATE14930 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "INVALIDATE", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._INVALIDATE_CHILD14931 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "INVALIDATE_CHILD", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._INVALIDATE_CHILD_IN_PARENT14932 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "INVALIDATE_CHILD_IN_PARENT", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._ON_LAYOUT14933 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "ON_LAYOUT", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._ON_MEASURE14934 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "ON_MEASURE", "Landroid/view/ViewDebug$HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._REQUEST_LAYOUT14935 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "REQUEST_LAYOUT", "Landroid/view/ViewDebug$HierarchyTraceType;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewDebug.IntToString_))]
		public partial interface IntToString : java.lang.annotation.Annotation
		{
			int from();
			global::java.lang.String to();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewDebug.IntToString))]
		public sealed partial class IntToString_ : java.lang.Object, IntToString
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static IntToString_()
			{
				InitJNI();
			}
			internal IntToString_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _from14936;
			 int android.view.ViewDebug.IntToString.from() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._from14936);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._from14936);
			}
			internal static global::MonoJavaBridge.MethodId _to14937;
			 global::java.lang.String android.view.ViewDebug.IntToString.to() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._to14937)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._to14937)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _equals14938;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._equals14938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._equals14938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString14939;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._toString14939)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._toString14939)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode14940;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._hashCode14940);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._hashCode14940);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType14941;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._annotationType14941)) as java.lang.Class;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._annotationType14941)) as java.lang.Class;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.IntToString_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$IntToString"));
				global::android.view.ViewDebug.IntToString_._from14936 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "from", "()I");
				global::android.view.ViewDebug.IntToString_._to14937 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "to", "()Ljava/lang/String;");
				global::android.view.ViewDebug.IntToString_._equals14938 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.IntToString_._toString14939 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.IntToString_._hashCode14940 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "hashCode", "()I");
				global::android.view.ViewDebug.IntToString_._annotationType14941 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "annotationType", "()Ljava/lang/Class;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class RecyclerTraceType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static RecyclerTraceType()
			{
				InitJNI();
			}
			internal RecyclerTraceType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values14942;
			public static global::android.view.ViewDebug.RecyclerTraceType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.RecyclerTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.RecyclerTraceType.staticClass, global::android.view.ViewDebug.RecyclerTraceType._values14942)) as android.view.ViewDebug.RecyclerTraceType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf14943;
			public static global::android.view.ViewDebug.RecyclerTraceType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.RecyclerTraceType.staticClass, global::android.view.ViewDebug.RecyclerTraceType._valueOf14943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewDebug.RecyclerTraceType;
			}
			internal static global::MonoJavaBridge.FieldId _BIND_VIEW14944;
			public static global::android.view.ViewDebug.RecyclerTraceType BIND_VIEW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _BIND_VIEW14944)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MOVE_FROM_ACTIVE_TO_SCRAP_HEAP14945;
			public static global::android.view.ViewDebug.RecyclerTraceType MOVE_FROM_ACTIVE_TO_SCRAP_HEAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _MOVE_FROM_ACTIVE_TO_SCRAP_HEAP14945)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MOVE_TO_SCRAP_HEAP14946;
			public static global::android.view.ViewDebug.RecyclerTraceType MOVE_TO_SCRAP_HEAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _MOVE_TO_SCRAP_HEAP14946)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEW_VIEW14947;
			public static global::android.view.ViewDebug.RecyclerTraceType NEW_VIEW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _NEW_VIEW14947)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RECYCLE_FROM_ACTIVE_HEAP14948;
			public static global::android.view.ViewDebug.RecyclerTraceType RECYCLE_FROM_ACTIVE_HEAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _RECYCLE_FROM_ACTIVE_HEAP14948)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RECYCLE_FROM_SCRAP_HEAP14949;
			public static global::android.view.ViewDebug.RecyclerTraceType RECYCLE_FROM_SCRAP_HEAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.ViewDebug.RecyclerTraceType>(@__env.GetStaticObjectField(global::android.view.ViewDebug.RecyclerTraceType.staticClass, _RECYCLE_FROM_SCRAP_HEAP14949)) as android.view.ViewDebug.RecyclerTraceType;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.RecyclerTraceType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$RecyclerTraceType"));
				global::android.view.ViewDebug.RecyclerTraceType._values14942 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._valueOf14943 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._BIND_VIEW14944 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "BIND_VIEW", "Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._MOVE_FROM_ACTIVE_TO_SCRAP_HEAP14945 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "MOVE_FROM_ACTIVE_TO_SCRAP_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._MOVE_TO_SCRAP_HEAP14946 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "MOVE_TO_SCRAP_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._NEW_VIEW14947 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "NEW_VIEW", "Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._RECYCLE_FROM_ACTIVE_HEAP14948 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "RECYCLE_FROM_ACTIVE_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._RECYCLE_FROM_SCRAP_HEAP14949 = @__env.GetStaticFieldIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "RECYCLE_FROM_SCRAP_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _trace14950;
		public static void trace(android.view.View arg0, android.view.ViewDebug.RecyclerTraceType arg1, int[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._trace14950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _trace14951;
		public static void trace(android.view.View arg0, android.view.ViewDebug.HierarchyTraceType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._trace14951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _startRecyclerTracing14952;
		public static void startRecyclerTracing(java.lang.String arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._startRecyclerTracing14952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stopRecyclerTracing14953;
		public static void stopRecyclerTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._stopRecyclerTracing14953);
		}
		internal static global::MonoJavaBridge.MethodId _startHierarchyTracing14954;
		public static void startHierarchyTracing(java.lang.String arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._startHierarchyTracing14954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stopHierarchyTracing14955;
		public static void stopHierarchyTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._stopHierarchyTracing14955);
		}
		internal static global::MonoJavaBridge.MethodId _dumpCapturedView14956;
		public static void dumpCapturedView(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._dumpCapturedView14956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ViewDebug14957;
		public ViewDebug()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._ViewDebug14957);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewDebug.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug"));
			global::android.view.ViewDebug._trace14950 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$RecyclerTraceType;[I)V");
			global::android.view.ViewDebug._trace14951 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$HierarchyTraceType;)V");
			global::android.view.ViewDebug._startRecyclerTracing14952 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "startRecyclerTracing", "(Ljava/lang/String;Landroid/view/View;)V");
			global::android.view.ViewDebug._stopRecyclerTracing14953 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "stopRecyclerTracing", "()V");
			global::android.view.ViewDebug._startHierarchyTracing14954 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "startHierarchyTracing", "(Ljava/lang/String;Landroid/view/View;)V");
			global::android.view.ViewDebug._stopHierarchyTracing14955 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "stopHierarchyTracing", "()V");
			global::android.view.ViewDebug._dumpCapturedView14956 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "dumpCapturedView", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::android.view.ViewDebug._ViewDebug14957 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "<init>", "()V");
		}
	}
}
