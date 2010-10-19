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
		public interface CapturedViewProperty : java.lang.annotation.Annotation
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
			internal static global::MonoJavaBridge.MethodId _retrieveReturn9975;
			 bool android.view.ViewDebug.CapturedViewProperty.retrieveReturn() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_._retrieveReturn9975);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, global::android.view.ViewDebug.CapturedViewProperty_._retrieveReturn9975);
			}
			internal static global::MonoJavaBridge.MethodId _equals9976;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_._equals9976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, global::android.view.ViewDebug.CapturedViewProperty_._equals9976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString9977;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_._toString9977)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, global::android.view.ViewDebug.CapturedViewProperty_._toString9977)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode9978;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_._hashCode9978);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, global::android.view.ViewDebug.CapturedViewProperty_._hashCode9978);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType9979;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_._annotationType9979)) as java.lang.Class;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, global::android.view.ViewDebug.CapturedViewProperty_._annotationType9979)) as java.lang.Class;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.CapturedViewProperty_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$CapturedViewProperty"));
				global::android.view.ViewDebug.CapturedViewProperty_._retrieveReturn9975 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "retrieveReturn", "()Z");
				global::android.view.ViewDebug.CapturedViewProperty_._equals9976 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.CapturedViewProperty_._toString9977 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.CapturedViewProperty_._hashCode9978 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "hashCode", "()I");
				global::android.view.ViewDebug.CapturedViewProperty_._annotationType9979 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "annotationType", "()Ljava/lang/Class;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewDebug.ExportedProperty_))]
		public interface ExportedProperty : java.lang.annotation.Annotation
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
			internal static global::MonoJavaBridge.MethodId _prefix9980;
			 global::java.lang.String android.view.ViewDebug.ExportedProperty.prefix() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._prefix9980)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._prefix9980)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _resolveId9981;
			 bool android.view.ViewDebug.ExportedProperty.resolveId() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._resolveId9981);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._resolveId9981);
			}
			internal static global::MonoJavaBridge.MethodId _mapping9982;
			 global::android.view.ViewDebug.IntToString[] android.view.ViewDebug.ExportedProperty.mapping() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.IntToString>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._mapping9982)) as android.view.ViewDebug.IntToString[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.IntToString>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._mapping9982)) as android.view.ViewDebug.IntToString[];
			}
			internal static global::MonoJavaBridge.MethodId _indexMapping9983;
			 global::android.view.ViewDebug.IntToString[] android.view.ViewDebug.ExportedProperty.indexMapping() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.IntToString>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._indexMapping9983)) as android.view.ViewDebug.IntToString[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.IntToString>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._indexMapping9983)) as android.view.ViewDebug.IntToString[];
			}
			internal static global::MonoJavaBridge.MethodId _flagMapping9984;
			 global::android.view.ViewDebug.FlagToString[] android.view.ViewDebug.ExportedProperty.flagMapping() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.FlagToString>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._flagMapping9984)) as android.view.ViewDebug.FlagToString[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.FlagToString>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._flagMapping9984)) as android.view.ViewDebug.FlagToString[];
			}
			internal static global::MonoJavaBridge.MethodId _deepExport9985;
			 bool android.view.ViewDebug.ExportedProperty.deepExport() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._deepExport9985);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._deepExport9985);
			}
			internal static global::MonoJavaBridge.MethodId _equals9986;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._equals9986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._equals9986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString9987;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._toString9987)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._toString9987)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode9988;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._hashCode9988);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._hashCode9988);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType9989;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._annotationType9989)) as java.lang.Class;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._annotationType9989)) as java.lang.Class;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.ExportedProperty_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$ExportedProperty"));
				global::android.view.ViewDebug.ExportedProperty_._prefix9980 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "prefix", "()Ljava/lang/String;");
				global::android.view.ViewDebug.ExportedProperty_._resolveId9981 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "resolveId", "()Z");
				global::android.view.ViewDebug.ExportedProperty_._mapping9982 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "mapping", "()[Landroid/view/ViewDebug/IntToString;");
				global::android.view.ViewDebug.ExportedProperty_._indexMapping9983 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "indexMapping", "()[Landroid/view/ViewDebug/IntToString;");
				global::android.view.ViewDebug.ExportedProperty_._flagMapping9984 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "flagMapping", "()[Landroid/view/ViewDebug/FlagToString;");
				global::android.view.ViewDebug.ExportedProperty_._deepExport9985 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "deepExport", "()Z");
				global::android.view.ViewDebug.ExportedProperty_._equals9986 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.ExportedProperty_._toString9987 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.ExportedProperty_._hashCode9988 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "hashCode", "()I");
				global::android.view.ViewDebug.ExportedProperty_._annotationType9989 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "annotationType", "()Ljava/lang/Class;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewDebug.FlagToString_))]
		public interface FlagToString : java.lang.annotation.Annotation
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
			internal static global::MonoJavaBridge.MethodId _name9990;
			 global::java.lang.String android.view.ViewDebug.FlagToString.name() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._name9990)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._name9990)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _equals9991;
			 int android.view.ViewDebug.FlagToString.equals() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._equals9991);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._equals9991);
			}
			internal static global::MonoJavaBridge.MethodId _mask9992;
			 int android.view.ViewDebug.FlagToString.mask() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._mask9992);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._mask9992);
			}
			internal static global::MonoJavaBridge.MethodId _outputIf9993;
			 bool android.view.ViewDebug.FlagToString.outputIf() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._outputIf9993);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._outputIf9993);
			}
			internal static global::MonoJavaBridge.MethodId _equals9994;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._equals9994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._equals9994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString9995;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._toString9995)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._toString9995)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode9996;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._hashCode9996);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._hashCode9996);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType9997;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._annotationType9997)) as java.lang.Class;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._annotationType9997)) as java.lang.Class;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.FlagToString_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$FlagToString"));
				global::android.view.ViewDebug.FlagToString_._name9990 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "name", "()Ljava/lang/String;");
				global::android.view.ViewDebug.FlagToString_._equals9991 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "equals", "()I");
				global::android.view.ViewDebug.FlagToString_._mask9992 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "mask", "()I");
				global::android.view.ViewDebug.FlagToString_._outputIf9993 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "outputIf", "()Z");
				global::android.view.ViewDebug.FlagToString_._equals9994 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.FlagToString_._toString9995 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.FlagToString_._hashCode9996 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "hashCode", "()I");
				global::android.view.ViewDebug.FlagToString_._annotationType9997 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "annotationType", "()Ljava/lang/Class;");
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
			internal static global::MonoJavaBridge.MethodId _values9998;
			public static global::android.view.ViewDebug.HierarchyTraceType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.HierarchyTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.HierarchyTraceType.staticClass, global::android.view.ViewDebug.HierarchyTraceType._values9998)) as android.view.ViewDebug.HierarchyTraceType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf9999;
			public static global::android.view.ViewDebug.HierarchyTraceType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.ViewDebug.HierarchyTraceType.staticClass, global::android.view.ViewDebug.HierarchyTraceType._valueOf9999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewDebug.HierarchyTraceType;
			}
			internal static global::MonoJavaBridge.FieldId _BUILD_CACHE10000;
			public static global::android.view.ViewDebug.HierarchyTraceType BUILD_CACHE
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DRAW10001;
			public static global::android.view.ViewDebug.HierarchyTraceType DRAW
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVALIDATE10002;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVALIDATE_CHILD10003;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVALIDATE_CHILD_IN_PARENT10004;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD_IN_PARENT
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON_LAYOUT10005;
			public static global::android.view.ViewDebug.HierarchyTraceType ON_LAYOUT
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON_MEASURE10006;
			public static global::android.view.ViewDebug.HierarchyTraceType ON_MEASURE
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _REQUEST_LAYOUT10007;
			public static global::android.view.ViewDebug.HierarchyTraceType REQUEST_LAYOUT
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.HierarchyTraceType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$HierarchyTraceType"));
				global::android.view.ViewDebug.HierarchyTraceType._values9998 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._valueOf9999 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$HierarchyTraceType;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewDebug.IntToString_))]
		public interface IntToString : java.lang.annotation.Annotation
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
			internal static global::MonoJavaBridge.MethodId _from10008;
			 int android.view.ViewDebug.IntToString.from() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._from10008);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._from10008);
			}
			internal static global::MonoJavaBridge.MethodId _to10009;
			 global::java.lang.String android.view.ViewDebug.IntToString.to() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._to10009)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._to10009)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _equals10010;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._equals10010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._equals10010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString10011;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._toString10011)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._toString10011)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode10012;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._hashCode10012);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._hashCode10012);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType10013;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._annotationType10013)) as java.lang.Class;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._annotationType10013)) as java.lang.Class;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.IntToString_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$IntToString"));
				global::android.view.ViewDebug.IntToString_._from10008 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "from", "()I");
				global::android.view.ViewDebug.IntToString_._to10009 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "to", "()Ljava/lang/String;");
				global::android.view.ViewDebug.IntToString_._equals10010 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.IntToString_._toString10011 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.IntToString_._hashCode10012 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "hashCode", "()I");
				global::android.view.ViewDebug.IntToString_._annotationType10013 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "annotationType", "()Ljava/lang/Class;");
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
			internal static global::MonoJavaBridge.MethodId _values10014;
			public static global::android.view.ViewDebug.RecyclerTraceType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.RecyclerTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.RecyclerTraceType.staticClass, global::android.view.ViewDebug.RecyclerTraceType._values10014)) as android.view.ViewDebug.RecyclerTraceType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf10015;
			public static global::android.view.ViewDebug.RecyclerTraceType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.ViewDebug.RecyclerTraceType.staticClass, global::android.view.ViewDebug.RecyclerTraceType._valueOf10015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewDebug.RecyclerTraceType;
			}
			internal static global::MonoJavaBridge.FieldId _BIND_VIEW10016;
			public static global::android.view.ViewDebug.RecyclerTraceType BIND_VIEW
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MOVE_FROM_ACTIVE_TO_SCRAP_HEAP10017;
			public static global::android.view.ViewDebug.RecyclerTraceType MOVE_FROM_ACTIVE_TO_SCRAP_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MOVE_TO_SCRAP_HEAP10018;
			public static global::android.view.ViewDebug.RecyclerTraceType MOVE_TO_SCRAP_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEW_VIEW10019;
			public static global::android.view.ViewDebug.RecyclerTraceType NEW_VIEW
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _RECYCLE_FROM_ACTIVE_HEAP10020;
			public static global::android.view.ViewDebug.RecyclerTraceType RECYCLE_FROM_ACTIVE_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _RECYCLE_FROM_SCRAP_HEAP10021;
			public static global::android.view.ViewDebug.RecyclerTraceType RECYCLE_FROM_SCRAP_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.RecyclerTraceType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$RecyclerTraceType"));
				global::android.view.ViewDebug.RecyclerTraceType._values10014 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._valueOf10015 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$RecyclerTraceType;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _trace10022;
		public static void trace(android.view.View arg0, android.view.ViewDebug.RecyclerTraceType arg1, int[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._trace10022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _trace10023;
		public static void trace(android.view.View arg0, android.view.ViewDebug.HierarchyTraceType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._trace10023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _startRecyclerTracing10024;
		public static void startRecyclerTracing(java.lang.String arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._startRecyclerTracing10024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stopRecyclerTracing10025;
		public static void stopRecyclerTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._stopRecyclerTracing10025);
		}
		internal static global::MonoJavaBridge.MethodId _startHierarchyTracing10026;
		public static void startHierarchyTracing(java.lang.String arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._startHierarchyTracing10026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stopHierarchyTracing10027;
		public static void stopHierarchyTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._stopHierarchyTracing10027);
		}
		internal static global::MonoJavaBridge.MethodId _dumpCapturedView10028;
		public static void dumpCapturedView(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._dumpCapturedView10028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ViewDebug10029;
		public ViewDebug()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._ViewDebug10029);
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
			global::android.view.ViewDebug._trace10022 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$RecyclerTraceType;[I)V");
			global::android.view.ViewDebug._trace10023 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$HierarchyTraceType;)V");
			global::android.view.ViewDebug._startRecyclerTracing10024 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "startRecyclerTracing", "(Ljava/lang/String;Landroid/view/View;)V");
			global::android.view.ViewDebug._stopRecyclerTracing10025 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "stopRecyclerTracing", "()V");
			global::android.view.ViewDebug._startHierarchyTracing10026 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "startHierarchyTracing", "(Ljava/lang/String;Landroid/view/View;)V");
			global::android.view.ViewDebug._stopHierarchyTracing10027 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "stopHierarchyTracing", "()V");
			global::android.view.ViewDebug._dumpCapturedView10028 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "dumpCapturedView", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::android.view.ViewDebug._ViewDebug10029 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "<init>", "()V");
		}
	}
}
