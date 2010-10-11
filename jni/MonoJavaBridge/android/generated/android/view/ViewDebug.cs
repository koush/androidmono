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
			internal static global::MonoJavaBridge.MethodId _retrieveReturn9429;
			 bool android.view.ViewDebug.CapturedViewProperty.retrieveReturn() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_._retrieveReturn9429);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, global::android.view.ViewDebug.CapturedViewProperty_._retrieveReturn9429);
			}
			internal static global::MonoJavaBridge.MethodId _equals9430;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_._equals9430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, global::android.view.ViewDebug.CapturedViewProperty_._equals9430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString9431;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_._toString9431)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, global::android.view.ViewDebug.CapturedViewProperty_._toString9431)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode9432;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_._hashCode9432);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, global::android.view.ViewDebug.CapturedViewProperty_._hashCode9432);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType9433;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_._annotationType9433)) as java.lang.Class;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.CapturedViewProperty_.staticClass, global::android.view.ViewDebug.CapturedViewProperty_._annotationType9433)) as java.lang.Class;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.CapturedViewProperty_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$CapturedViewProperty"));
				global::android.view.ViewDebug.CapturedViewProperty_._retrieveReturn9429 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "retrieveReturn", "()Z");
				global::android.view.ViewDebug.CapturedViewProperty_._equals9430 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.CapturedViewProperty_._toString9431 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.CapturedViewProperty_._hashCode9432 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "hashCode", "()I");
				global::android.view.ViewDebug.CapturedViewProperty_._annotationType9433 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.CapturedViewProperty_.staticClass, "annotationType", "()Ljava/lang/Class;");
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
			internal static global::MonoJavaBridge.MethodId _prefix9434;
			 global::java.lang.String android.view.ViewDebug.ExportedProperty.prefix() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._prefix9434)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._prefix9434)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _resolveId9435;
			 bool android.view.ViewDebug.ExportedProperty.resolveId() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._resolveId9435);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._resolveId9435);
			}
			internal static global::MonoJavaBridge.MethodId _mapping9436;
			 global::android.view.ViewDebug.IntToString[] android.view.ViewDebug.ExportedProperty.mapping() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.IntToString>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._mapping9436)) as android.view.ViewDebug.IntToString[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.IntToString>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._mapping9436)) as android.view.ViewDebug.IntToString[];
			}
			internal static global::MonoJavaBridge.MethodId _indexMapping9437;
			 global::android.view.ViewDebug.IntToString[] android.view.ViewDebug.ExportedProperty.indexMapping() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.IntToString>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._indexMapping9437)) as android.view.ViewDebug.IntToString[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.IntToString>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._indexMapping9437)) as android.view.ViewDebug.IntToString[];
			}
			internal static global::MonoJavaBridge.MethodId _flagMapping9438;
			 global::android.view.ViewDebug.FlagToString[] android.view.ViewDebug.ExportedProperty.flagMapping() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.FlagToString>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._flagMapping9438)) as android.view.ViewDebug.FlagToString[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.FlagToString>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._flagMapping9438)) as android.view.ViewDebug.FlagToString[];
			}
			internal static global::MonoJavaBridge.MethodId _deepExport9439;
			 bool android.view.ViewDebug.ExportedProperty.deepExport() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._deepExport9439);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._deepExport9439);
			}
			internal static global::MonoJavaBridge.MethodId _equals9440;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._equals9440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._equals9440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString9441;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._toString9441)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._toString9441)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode9442;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._hashCode9442);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._hashCode9442);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType9443;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_._annotationType9443)) as java.lang.Class;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.ExportedProperty_.staticClass, global::android.view.ViewDebug.ExportedProperty_._annotationType9443)) as java.lang.Class;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.ExportedProperty_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$ExportedProperty"));
				global::android.view.ViewDebug.ExportedProperty_._prefix9434 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "prefix", "()Ljava/lang/String;");
				global::android.view.ViewDebug.ExportedProperty_._resolveId9435 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "resolveId", "()Z");
				global::android.view.ViewDebug.ExportedProperty_._mapping9436 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "mapping", "()[Landroid/view/ViewDebug/IntToString;");
				global::android.view.ViewDebug.ExportedProperty_._indexMapping9437 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "indexMapping", "()[Landroid/view/ViewDebug/IntToString;");
				global::android.view.ViewDebug.ExportedProperty_._flagMapping9438 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "flagMapping", "()[Landroid/view/ViewDebug/FlagToString;");
				global::android.view.ViewDebug.ExportedProperty_._deepExport9439 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "deepExport", "()Z");
				global::android.view.ViewDebug.ExportedProperty_._equals9440 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.ExportedProperty_._toString9441 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.ExportedProperty_._hashCode9442 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "hashCode", "()I");
				global::android.view.ViewDebug.ExportedProperty_._annotationType9443 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.ExportedProperty_.staticClass, "annotationType", "()Ljava/lang/Class;");
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
			internal static global::MonoJavaBridge.MethodId _name9444;
			 global::java.lang.String android.view.ViewDebug.FlagToString.name() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._name9444)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._name9444)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _equals9445;
			 int android.view.ViewDebug.FlagToString.equals() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._equals9445);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._equals9445);
			}
			internal static global::MonoJavaBridge.MethodId _mask9446;
			 int android.view.ViewDebug.FlagToString.mask() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._mask9446);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._mask9446);
			}
			internal static global::MonoJavaBridge.MethodId _outputIf9447;
			 bool android.view.ViewDebug.FlagToString.outputIf() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._outputIf9447);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._outputIf9447);
			}
			internal static global::MonoJavaBridge.MethodId _equals9448;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._equals9448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._equals9448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString9449;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._toString9449)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._toString9449)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode9450;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._hashCode9450);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._hashCode9450);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType9451;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_._annotationType9451)) as java.lang.Class;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.FlagToString_.staticClass, global::android.view.ViewDebug.FlagToString_._annotationType9451)) as java.lang.Class;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.FlagToString_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$FlagToString"));
				global::android.view.ViewDebug.FlagToString_._name9444 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "name", "()Ljava/lang/String;");
				global::android.view.ViewDebug.FlagToString_._equals9445 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "equals", "()I");
				global::android.view.ViewDebug.FlagToString_._mask9446 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "mask", "()I");
				global::android.view.ViewDebug.FlagToString_._outputIf9447 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "outputIf", "()Z");
				global::android.view.ViewDebug.FlagToString_._equals9448 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.FlagToString_._toString9449 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.FlagToString_._hashCode9450 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "hashCode", "()I");
				global::android.view.ViewDebug.FlagToString_._annotationType9451 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.FlagToString_.staticClass, "annotationType", "()Ljava/lang/Class;");
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
			internal static global::MonoJavaBridge.MethodId _values9452;
			public static global::android.view.ViewDebug.HierarchyTraceType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.HierarchyTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.HierarchyTraceType.staticClass, global::android.view.ViewDebug.HierarchyTraceType._values9452)) as android.view.ViewDebug.HierarchyTraceType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf9453;
			public static global::android.view.ViewDebug.HierarchyTraceType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.ViewDebug.HierarchyTraceType.staticClass, global::android.view.ViewDebug.HierarchyTraceType._valueOf9453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewDebug.HierarchyTraceType;
			}
			internal static global::MonoJavaBridge.FieldId _BUILD_CACHE9454;
			public static global::android.view.ViewDebug.HierarchyTraceType BUILD_CACHE
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DRAW9455;
			public static global::android.view.ViewDebug.HierarchyTraceType DRAW
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVALIDATE9456;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVALIDATE_CHILD9457;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _INVALIDATE_CHILD_IN_PARENT9458;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD_IN_PARENT
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON_LAYOUT9459;
			public static global::android.view.ViewDebug.HierarchyTraceType ON_LAYOUT
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ON_MEASURE9460;
			public static global::android.view.ViewDebug.HierarchyTraceType ON_MEASURE
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _REQUEST_LAYOUT9461;
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
				global::android.view.ViewDebug.HierarchyTraceType._values9452 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._valueOf9453 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$HierarchyTraceType;");
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
			internal static global::MonoJavaBridge.MethodId _from9462;
			 int android.view.ViewDebug.IntToString.from() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._from9462);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._from9462);
			}
			internal static global::MonoJavaBridge.MethodId _to9463;
			 global::java.lang.String android.view.ViewDebug.IntToString.to() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._to9463)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._to9463)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _equals9464;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._equals9464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._equals9464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString9465;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._toString9465)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._toString9465)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode9466;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._hashCode9466);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._hashCode9466);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType9467;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_._annotationType9467)) as java.lang.Class;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewDebug.IntToString_.staticClass, global::android.view.ViewDebug.IntToString_._annotationType9467)) as java.lang.Class;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewDebug.IntToString_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewDebug$IntToString"));
				global::android.view.ViewDebug.IntToString_._from9462 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "from", "()I");
				global::android.view.ViewDebug.IntToString_._to9463 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "to", "()Ljava/lang/String;");
				global::android.view.ViewDebug.IntToString_._equals9464 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.IntToString_._toString9465 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.IntToString_._hashCode9466 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "hashCode", "()I");
				global::android.view.ViewDebug.IntToString_._annotationType9467 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.IntToString_.staticClass, "annotationType", "()Ljava/lang/Class;");
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
			internal static global::MonoJavaBridge.MethodId _values9468;
			public static global::android.view.ViewDebug.RecyclerTraceType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.view.ViewDebug.RecyclerTraceType>(@__env.CallStaticObjectMethod(android.view.ViewDebug.RecyclerTraceType.staticClass, global::android.view.ViewDebug.RecyclerTraceType._values9468)) as android.view.ViewDebug.RecyclerTraceType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf9469;
			public static global::android.view.ViewDebug.RecyclerTraceType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.ViewDebug.RecyclerTraceType.staticClass, global::android.view.ViewDebug.RecyclerTraceType._valueOf9469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewDebug.RecyclerTraceType;
			}
			internal static global::MonoJavaBridge.FieldId _BIND_VIEW9470;
			public static global::android.view.ViewDebug.RecyclerTraceType BIND_VIEW
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MOVE_FROM_ACTIVE_TO_SCRAP_HEAP9471;
			public static global::android.view.ViewDebug.RecyclerTraceType MOVE_FROM_ACTIVE_TO_SCRAP_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MOVE_TO_SCRAP_HEAP9472;
			public static global::android.view.ViewDebug.RecyclerTraceType MOVE_TO_SCRAP_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEW_VIEW9473;
			public static global::android.view.ViewDebug.RecyclerTraceType NEW_VIEW
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _RECYCLE_FROM_ACTIVE_HEAP9474;
			public static global::android.view.ViewDebug.RecyclerTraceType RECYCLE_FROM_ACTIVE_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _RECYCLE_FROM_SCRAP_HEAP9475;
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
				global::android.view.ViewDebug.RecyclerTraceType._values9468 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._valueOf9469 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$RecyclerTraceType;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _trace9476;
		public static void trace(android.view.View arg0, android.view.ViewDebug.RecyclerTraceType arg1, int[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._trace9476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _trace9477;
		public static void trace(android.view.View arg0, android.view.ViewDebug.HierarchyTraceType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._trace9477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _startRecyclerTracing9478;
		public static void startRecyclerTracing(java.lang.String arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._startRecyclerTracing9478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stopRecyclerTracing9479;
		public static void stopRecyclerTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._stopRecyclerTracing9479);
		}
		internal static global::MonoJavaBridge.MethodId _startHierarchyTracing9480;
		public static void startHierarchyTracing(java.lang.String arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._startHierarchyTracing9480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stopHierarchyTracing9481;
		public static void stopHierarchyTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._stopHierarchyTracing9481);
		}
		internal static global::MonoJavaBridge.MethodId _dumpCapturedView9482;
		public static void dumpCapturedView(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._dumpCapturedView9482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ViewDebug9483;
		public ViewDebug()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._ViewDebug9483);
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
			global::android.view.ViewDebug._trace9476 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$RecyclerTraceType;[I)V");
			global::android.view.ViewDebug._trace9477 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$HierarchyTraceType;)V");
			global::android.view.ViewDebug._startRecyclerTracing9478 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "startRecyclerTracing", "(Ljava/lang/String;Landroid/view/View;)V");
			global::android.view.ViewDebug._stopRecyclerTracing9479 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "stopRecyclerTracing", "()V");
			global::android.view.ViewDebug._startHierarchyTracing9480 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "startHierarchyTracing", "(Ljava/lang/String;Landroid/view/View;)V");
			global::android.view.ViewDebug._stopHierarchyTracing9481 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "stopHierarchyTracing", "()V");
			global::android.view.ViewDebug._dumpCapturedView9482 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "dumpCapturedView", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::android.view.ViewDebug._ViewDebug9483 = @__env.GetMethodIDNoThrow(global::android.view.ViewDebug.staticClass, "<init>", "()V");
		}
	}
}
