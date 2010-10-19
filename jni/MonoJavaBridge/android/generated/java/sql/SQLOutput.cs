namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.SQLOutput_))]
	public interface SQLOutput  : global::MonoJavaBridge.IJavaObject 
	{
		void writeObject(java.sql.SQLData arg0);
		void writeInt(int arg0);
		void writeBytes(byte[] arg0);
		void writeLong(long arg0);
		void writeByte(byte arg0);
		void writeShort(short arg0);
		void writeFloat(float arg0);
		void writeString(java.lang.String arg0);
		void writeDouble(double arg0);
		void writeArray(java.sql.Array arg0);
		void writeBoolean(bool arg0);
		void writeBigDecimal(java.math.BigDecimal arg0);
		void writeDate(java.sql.Date arg0);
		void writeTime(java.sql.Time arg0);
		void writeTimestamp(java.sql.Timestamp arg0);
		void writeCharacterStream(java.io.Reader arg0);
		void writeAsciiStream(java.io.InputStream arg0);
		void writeBinaryStream(java.io.InputStream arg0);
		void writeRef(java.sql.Ref arg0);
		void writeBlob(java.sql.Blob arg0);
		void writeClob(java.sql.Clob arg0);
		void writeStruct(java.sql.Struct arg0);
		void writeURL(java.net.URL arg0);
		void writeNString(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.SQLOutput))]
	public sealed partial class SQLOutput_ : java.lang.Object, SQLOutput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLOutput_()
		{
			InitJNI();
		}
		internal SQLOutput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeObject19193;
		 void java.sql.SQLOutput.writeObject(java.sql.SQLData arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeObject19193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeObject19193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeInt19194;
		 void java.sql.SQLOutput.writeInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeInt19194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeInt19194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes19195;
		 void java.sql.SQLOutput.writeBytes(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeBytes19195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeBytes19195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLong19196;
		 void java.sql.SQLOutput.writeLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeLong19196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeLong19196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte19197;
		 void java.sql.SQLOutput.writeByte(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeByte19197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeByte19197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort19198;
		 void java.sql.SQLOutput.writeShort(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeShort19198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeShort19198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat19199;
		 void java.sql.SQLOutput.writeFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeFloat19199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeFloat19199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeString19200;
		 void java.sql.SQLOutput.writeString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeString19200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeString19200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble19201;
		 void java.sql.SQLOutput.writeDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeDouble19201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeDouble19201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeArray19202;
		 void java.sql.SQLOutput.writeArray(java.sql.Array arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeArray19202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeArray19202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean19203;
		 void java.sql.SQLOutput.writeBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeBoolean19203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeBoolean19203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBigDecimal19204;
		 void java.sql.SQLOutput.writeBigDecimal(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeBigDecimal19204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeBigDecimal19204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDate19205;
		 void java.sql.SQLOutput.writeDate(java.sql.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeDate19205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeDate19205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeTime19206;
		 void java.sql.SQLOutput.writeTime(java.sql.Time arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeTime19206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeTime19206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeTimestamp19207;
		 void java.sql.SQLOutput.writeTimestamp(java.sql.Timestamp arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeTimestamp19207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeTimestamp19207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeCharacterStream19208;
		 void java.sql.SQLOutput.writeCharacterStream(java.io.Reader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeCharacterStream19208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeCharacterStream19208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeAsciiStream19209;
		 void java.sql.SQLOutput.writeAsciiStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeAsciiStream19209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeAsciiStream19209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBinaryStream19210;
		 void java.sql.SQLOutput.writeBinaryStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeBinaryStream19210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeBinaryStream19210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeRef19211;
		 void java.sql.SQLOutput.writeRef(java.sql.Ref arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeRef19211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeRef19211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBlob19212;
		 void java.sql.SQLOutput.writeBlob(java.sql.Blob arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeBlob19212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeBlob19212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeClob19213;
		 void java.sql.SQLOutput.writeClob(java.sql.Clob arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeClob19213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeClob19213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStruct19214;
		 void java.sql.SQLOutput.writeStruct(java.sql.Struct arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeStruct19214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeStruct19214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeURL19215;
		 void java.sql.SQLOutput.writeURL(java.net.URL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeURL19215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeURL19215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeNString19216;
		 void java.sql.SQLOutput.writeNString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_._writeNString19216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLOutput_.staticClass, global::java.sql.SQLOutput_._writeNString19216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLOutput"));
			global::java.sql.SQLOutput_._writeObject19193 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeObject", "(Ljava/sql/SQLData;)V");
			global::java.sql.SQLOutput_._writeInt19194 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeInt", "(I)V");
			global::java.sql.SQLOutput_._writeBytes19195 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeBytes", "([B)V");
			global::java.sql.SQLOutput_._writeLong19196 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeLong", "(J)V");
			global::java.sql.SQLOutput_._writeByte19197 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeByte", "(B)V");
			global::java.sql.SQLOutput_._writeShort19198 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeShort", "(S)V");
			global::java.sql.SQLOutput_._writeFloat19199 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeFloat", "(F)V");
			global::java.sql.SQLOutput_._writeString19200 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeString", "(Ljava/lang/String;)V");
			global::java.sql.SQLOutput_._writeDouble19201 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeDouble", "(D)V");
			global::java.sql.SQLOutput_._writeArray19202 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeArray", "(Ljava/sql/Array;)V");
			global::java.sql.SQLOutput_._writeBoolean19203 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeBoolean", "(Z)V");
			global::java.sql.SQLOutput_._writeBigDecimal19204 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeBigDecimal", "(Ljava/math/BigDecimal;)V");
			global::java.sql.SQLOutput_._writeDate19205 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeDate", "(Ljava/sql/Date;)V");
			global::java.sql.SQLOutput_._writeTime19206 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeTime", "(Ljava/sql/Time;)V");
			global::java.sql.SQLOutput_._writeTimestamp19207 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeTimestamp", "(Ljava/sql/Timestamp;)V");
			global::java.sql.SQLOutput_._writeCharacterStream19208 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeCharacterStream", "(Ljava/io/Reader;)V");
			global::java.sql.SQLOutput_._writeAsciiStream19209 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeAsciiStream", "(Ljava/io/InputStream;)V");
			global::java.sql.SQLOutput_._writeBinaryStream19210 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeBinaryStream", "(Ljava/io/InputStream;)V");
			global::java.sql.SQLOutput_._writeRef19211 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeRef", "(Ljava/sql/Ref;)V");
			global::java.sql.SQLOutput_._writeBlob19212 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeBlob", "(Ljava/sql/Blob;)V");
			global::java.sql.SQLOutput_._writeClob19213 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeClob", "(Ljava/sql/Clob;)V");
			global::java.sql.SQLOutput_._writeStruct19214 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeStruct", "(Ljava/sql/Struct;)V");
			global::java.sql.SQLOutput_._writeURL19215 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeURL", "(Ljava/net/URL;)V");
			global::java.sql.SQLOutput_._writeNString19216 = @__env.GetMethodIDNoThrow(global::java.sql.SQLOutput_.staticClass, "writeNString", "(Ljava/lang/String;)V");
		}
	}
}
